using System.Collections.Generic;
using Blood_Bank_Final.Infrastructure;

namespace Blood_Bank_Final.Application.Abstract
{
	public interface IApplicationMethodElasticSearch
	{
		List<DonorModel> GetDonors(string searchString);
		DonorModel Post(DonorModel donor);
	}
}