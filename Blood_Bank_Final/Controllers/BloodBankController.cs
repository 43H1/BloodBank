using Blood_Bank_Final.Application.Abstract;
using Blood_Bank_Final.Infrastructure;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blood_Bank_Final.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BloodBankController : Controller
    {
        // GET: BloodBank
        IApplicationMethodSQL applicationMethodSQL;
		IApplicationMethodMongo applicationMethodMongo;
		IApplicationMethodElasticSearch applicationMethodElasticSearch;
		public BloodBankController(IApplicationMethodSQL applicationMethodSQL,IApplicationMethodMongo applicationMethodMongo, IApplicationMethodElasticSearch applicationMethodElasticSearch)
        {
            this.applicationMethodSQL = applicationMethodSQL;
			this.applicationMethodMongo = applicationMethodMongo;
          this.applicationMethodElasticSearch = applicationMethodElasticSearch;
        }
        public ActionResult Index()
        {
            ViewBag.Donors= applicationMethodSQL.GetDonors();
            return View();
        }
        [Authorize(Roles ="Admin")]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DonorModel donor)
        {
			
			DonorModel _donor= applicationMethodSQL.PostDonor(donor);
			var jobId = BackgroundJob.Enqueue(
				() => applicationMethodMongo.PostDonor(_donor));
			applicationMethodElasticSearch.Post(donor);

			return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            DonorModel donor = applicationMethodSQL.Find(id);
           
            return View(donor);
        }
        [HttpPost]
        public ActionResult Edit(DonorModel donor)
        {
			
			DonorModel _donor=applicationMethodSQL.EditDonor(donor);
			var jobId = BackgroundJob.Enqueue(
			() =>applicationMethodMongo.EditDonor(_donor));

			return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {

            DonorModel donor = applicationMethodSQL.Find(id);
           
            return View(donor);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            DonorModel donor = applicationMethodSQL.Find(id);
            applicationMethodSQL.DeleteDonor(donor);
			var jobId = BackgroundJob.Enqueue(
			() => applicationMethodMongo.DeleteDonor(donor));
			return RedirectToAction("Index");
        }
    }
}