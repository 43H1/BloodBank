using Blood_Bank_Final.Application.Abstract;
using Blood_Bank_Final.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Blood_Bank_Final.Controllers
{
    public class BloodBankApiController : ApiController
    {
		IApplicationMethodMongo applicationMethodMongo;
		public BloodBankApiController(IApplicationMethodMongo applicationMethodMongo)
		{
			this.applicationMethodMongo = applicationMethodMongo;
		}
		[HttpGet]
		public IHttpActionResult GetDonors()
		{
			var Donor =applicationMethodMongo.GetDonors();
			return Ok(Donor);
		}
		[HttpPost]
		public IHttpActionResult PostDonors(DonorModel donor)
		{
			applicationMethodMongo.PostDonor(donor);
			return Ok();
		}
	}
}
