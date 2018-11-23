using Blood_Bank_Final.DataAccess.Abstract;
using Blood_Bank_Final.Domain.Abstract;
using Blood_Bank_Final.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.Domain
{
    public class DomainMethodSQL : IDomainMethodSQL
    {
        ISqlMethods sqlMethods;

        public DomainMethodSQL(ISqlMethods sqlMethods)
        {
            this.sqlMethods = sqlMethods;
        }
        public List<DonorModel> GetDonors()
        {
            List<DonorModel> list = sqlMethods.GetDonors().ToList();
            //List<IDomainModelSQL> domainModelSQL = new List<IDomainModelSQL>();


            //foreach (var item in list)
            //{
            //    IDomainModelSQL donor = new DomainModelSQL
            //    {
            //        DonorId = item.DonorId,
            //        DonorName = item.DonorName,
            //        BloodGroup = item.BloodGroup
            //    };
            //    domainModelSQL.Add(donor);
            //}
            return list;
        }
        public DonorModel PostDonor(DonorModel donor)
        {
        //    bloodDonor.DonorId = donor.DonorId;
        //    bloodDonor.DonorName = donor.DonorName;
        //    bloodDonor.BloodGroup = donor.BloodGroup;
            return sqlMethods.PostDonor(donor);
        }
    public DonorModel Find(int? id)
        {
            DonorModel donor = GetDonors().Find(p => p.DonorId == id);
            return donor;
        }
        public DonorModel EditDonor(DonorModel donor)
        {

            //bloodDonor.DonorId = donor.DonorId;
            //bloodDonor.DonorName = donor.DonorName;
            //bloodDonor.BloodGroup = donor.BloodGroup;
            return sqlMethods.EditDonor(donor);
        }
        public void DeleteDonor(DonorModel donor)
        {
            //bloodDonor.DonorId = donor.DonorId;
            //bloodDonor.DonorName = donor.DonorName;
            //bloodDonor.BloodGroup = donor.BloodGroup;
            sqlMethods.DeleteDonor(donor);
        }

    }
}
