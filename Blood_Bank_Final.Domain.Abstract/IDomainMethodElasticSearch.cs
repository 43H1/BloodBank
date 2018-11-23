using System.Collections.Generic;
using Blood_Bank_Final.Infrastructure;

namespace Blood_Bank_Final.Domain.Abstract
{
	public interface IDomainMethodElasticSearch
	{
		List<DonorModel> GetDonors(string searchString);
		DonorModel Post(DonorModel donor);
	}
}