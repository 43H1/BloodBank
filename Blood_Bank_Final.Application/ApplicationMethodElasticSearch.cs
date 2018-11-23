using Blood_Bank_Final.Application.Abstract;
using Blood_Bank_Final.Domain.Abstract;
using Blood_Bank_Final.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.Application
{
	public class ApplicationMethodElasticSearch : IApplicationMethodElasticSearch
	{
		IDomainMethodElasticSearch domainMethodElasticSearch;

		public ApplicationMethodElasticSearch(IDomainMethodElasticSearch domainMethodElasticSearch)
		{
			this.domainMethodElasticSearch = domainMethodElasticSearch;

		}
		public List<DonorModel> GetDonors(string searchString)
		{
			List<DonorModel> list = domainMethodElasticSearch.GetDonors(searchString).ToList();
			
			return list;
		}
		public DonorModel Post(DonorModel donor)
		{

			return domainMethodElasticSearch.Post(donor);
		}
	}
}
