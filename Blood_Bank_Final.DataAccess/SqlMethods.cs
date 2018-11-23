using Blood_Bank_Final.DataAccess.Abstract;
using Blood_Bank_Final.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.DataAccess
{
     public class SqlMethods : ISqlMethods
    {
        BloodBankEntities bloodBankEntities = new BloodBankEntities();
        public List<DonorModel> GetDonors()
        {
            List<bloodDonor> donors = bloodBankEntities.bloodDonors.ToList();
            List<DonorModel> donorList = new List<DonorModel>();
            foreach (var item in donors)
            {
                DonorModel donor = new DonorModel
                {
                    DonorId = item.DonorId,
                    DonorName = item.DonorName,
                    BloodGroup = item.BloodGroup
                };
                donorList.Add(donor);
            }
            return donorList;

        }
        public DonorModel PostDonor(DonorModel bloodDonor)
        {
            bloodDonor _bloodDonor = new bloodDonor
            {
                DonorId = bloodDonor.DonorId,
                DonorName = bloodDonor.DonorName,
                BloodGroup = bloodDonor.BloodGroup
            };
            bloodBankEntities.bloodDonors.Add(_bloodDonor);
            bloodBankEntities.SaveChanges();
			bloodDonor.DonorId = _bloodDonor.DonorId;
			return bloodDonor;
        }
        public DonorModel EditDonor(DonorModel bloodDonor)
        {
            bloodDonor _bloodDonor = new bloodDonor
            {
                DonorId = bloodDonor.DonorId,
                DonorName = bloodDonor.DonorName,
                BloodGroup = bloodDonor.BloodGroup
            };
            bloodBankEntities.Entry(_bloodDonor).State = EntityState.Modified;
            bloodBankEntities.SaveChanges();
			bloodDonor.DonorId = _bloodDonor.DonorId;
			bloodDonor.DonorName = _bloodDonor.DonorName;
			bloodDonor.BloodGroup = _bloodDonor.BloodGroup;
			return bloodDonor;
		}
        public void DeleteDonor(DonorModel bloodDonor)
        {
            bloodDonor _bloodDonor = new bloodDonor
            {
                DonorId = bloodDonor.DonorId,
                DonorName = bloodDonor.DonorName,
                BloodGroup = bloodDonor.BloodGroup
            };


            using (BloodBankEntities context = new BloodBankEntities())
            {

                context.bloodDonors.Attach(_bloodDonor);
                context.bloodDonors.Remove(_bloodDonor);
                context.SaveChanges();
            }

        }
    }
}
