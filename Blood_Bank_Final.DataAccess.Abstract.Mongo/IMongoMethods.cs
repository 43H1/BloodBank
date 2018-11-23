using System.Collections.Generic;
using Blood_Bank_Final.Infrastructure;

namespace Blood_Bank_Final.DataAccess.Abstract.Mongo
{
	public interface IMongoMethods
	{
		void DeleteDonor(DonorModel bloodDonor);
		void EditDonor(DonorModel bloodDonor);
		List<DonorModel> GetDonors();
		void PostDonor(DonorModel bloodDonor);
	}
}