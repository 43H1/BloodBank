using System.Collections.Generic;
using Blood_Bank_Final.Infrastructure;

namespace Blood_Bank_Final.Domain.Abstract
{
	public interface IDomainMethodMongo
	{
		void DeleteDonor(DonorModel donor);
		void EditDonor(DonorModel donor);
		DonorModel Find(int? id);
		List<DonorModel> GetDonors();
		void PostDonor(DonorModel donor);
	}
}