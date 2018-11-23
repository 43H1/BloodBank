using System.Collections.Generic;
using Blood_Bank_Final.Application.Abstract;
using Blood_Bank_Final.Infrastructure;

namespace Blood_Bank_Final.Application.Abstract
{
    public interface IApplicationMethodSQL
    {
        List<DonorModel> GetDonors();
		DonorModel PostDonor(DonorModel donor);
        DonorModel Find(int? id);
		DonorModel EditDonor(DonorModel applicationBookModel);
        void DeleteDonor(DonorModel applicationBookModel);

    }
}