using System.Linq;
using Blood_Bank_Final.DataAccess.Abstract;
using System.Collections.Generic;
using Blood_Bank_Final.Infrastructure;

namespace Blood_Bank_Final.DataAccess.Abstract
{
    public interface ISqlMethods
    {
        List<DonorModel> GetDonors();
		DonorModel PostDonor(DonorModel bloodDonor);
		DonorModel EditDonor(DonorModel bloodDonor);
        void DeleteDonor(DonorModel bloodDonor);
    }
}