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
    public class SearchController : ApiController
    {
		IApplicationMethodElasticSearch applicationMethodElastic;
		public SearchController(IApplicationMethodElasticSearch applicationMethodElastic)
		{
			this.applicationMethodElastic = applicationMethodElastic;
		}
		public List<DonorModel> GetDonors(string id)
		{
			List<DonorModel> list = applicationMethodElastic.GetDonors(id).ToList();

			return list;
		}
	}
}
