using System.Collections.Generic;
using Blood_Bank_Final.Infrastructure;
using Nest;

namespace Blood_Bank_Final.DataAccess.ElasticSearch.Abstract
{
	public interface IElasticConfig
	{
		List<DonorModel> GetAll(string searchString);
		DonorModel Post(DonorModel donor);
	}
}