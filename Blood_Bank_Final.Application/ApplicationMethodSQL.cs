using Blood_Bank_Final.Application.Abstract;
using Blood_Bank_Final.Domain.Abstract;
using Blood_Bank_Final.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.Application
{
    public class ApplicationMethodSQL : IApplicationMethodSQL
    {
        IDomainMethodSQL domainServiceSQL;
        
        public ApplicationMethodSQL(IDomainMethodSQL domainServiceSQL)
        {
            this.domainServiceSQL = domainServiceSQL;

        }
        public List<DonorModel> GetDonors()
        {
            List<DonorModel> list = domainServiceSQL.GetDonors().ToList();
            //List<IApplicationModelSQL> books = new List<IApplicationModelSQL>();
            //foreach (var item in list)
            //{
            //    IApplicationModelSQL applicationBookModel = new ApplicationModelSQL
            //    {

            //        DonorId = item.DonorId,
            //        DonorName = item.DonorName,
            //        BloodGroup = item.BloodGroup
            //    };
            //    books.Add(applicationBookModel);
            //}
            return list;
        }
        public DonorModel PostDonor(DonorModel donor)
        {
            //domainModelSQL.DonorId = donor.DonorId;
            //domainModelSQL.DonorName = donor.DonorName;
            //domainModelSQL.BloodGroup = donor.BloodGroup;
			return domainServiceSQL.PostDonor(donor);
		}

        public DonorModel Find(int? id)
        {
            DonorModel DonorReturned = domainServiceSQL.Find(id);
            //IApplicationModelSQL applicationModelSQL = new ApplicationModelSQL
            //{

            //    DonorId = DonorReturned.DonorId,
            //    DonorName = DonorReturned.DonorName,
            //    BloodGroup = DonorReturned.BloodGroup
            //};

            return DonorReturned;
        }
        public DonorModel EditDonor(DonorModel donor)
        {
            //domainModelSQL.DonorId = applicationModelSQL.DonorId;
            //domainModelSQL.DonorName = applicationModelSQL.DonorName;
            //domainModelSQL.BloodGroup = applicationModelSQL.BloodGroup;
            return domainServiceSQL.EditDonor(donor);
        }
        public void DeleteDonor(DonorModel donor)
        {
            //domainModelSQL.DonorId = applicationModelSQL.DonorId;
            //domainModelSQL.DonorName = applicationModelSQL.DonorName;
            //domainModelSQL.BloodGroup = applicationModelSQL.BloodGroup;
            domainServiceSQL.DeleteDonor(donor);
        }

    }
}