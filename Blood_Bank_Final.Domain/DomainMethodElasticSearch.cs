using Blood_Bank_Final.DataAccess.ElasticSearch.Abstract;
using Blood_Bank_Final.Domain.Abstract;
using Blood_Bank_Final.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.Domain
{
	public class DomainMethodElasticSearch : IDomainMethodElasticSearch
	{
		IElasticConfig elasticConfig;

		public DomainMethodElasticSearch(IElasticConfig elasticConfig)
		{
			this.elasticConfig = elasticConfig;
		}
		public List<DonorModel> GetDonors(string searchString)
		{
			List<DonorModel> list = elasticConfig.GetAll(searchString).ToList();
			return list;
		}
		public DonorModel Post(DonorModel donor)
		{
			return elasticConfig.Post(donor);
		}
	}
}
