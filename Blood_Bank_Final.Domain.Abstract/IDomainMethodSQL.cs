using System.Collections.Generic;
using Blood_Bank_Final.Domain.Abstract;
using Blood_Bank_Final.Infrastructure;

namespace Blood_Bank_Final.Domain.Abstract
{
    public interface IDomainMethodSQL
    {
        List<DonorModel> GetDonors();
		DonorModel PostDonor(DonorModel donor);
        DonorModel Find(int? id);
		DonorModel EditDonor(DonorModel donor);
        void DeleteDonor(DonorModel donor);
    }
}