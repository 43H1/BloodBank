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
	public class ApplicationMethodMongo : IApplicationMethodMongo
	{   
        IDomainMethodMongo domainServiceMongo;

		public ApplicationMethodMongo(IDomainMethodMongo domainServiceMongo)
		{
			this.domainServiceMongo = domainServiceMongo;

		}
		public List<DonorModel> GetDonors()
		{
			List<DonorModel> list = domainServiceMongo.GetDonors().ToList();
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
		public void PostDonor(DonorModel donor)
		{
			//domainModelSQL.DonorId = donor.DonorId;
			//domainModelSQL.DonorName = donor.DonorName;
			//domainModelSQL.BloodGroup = donor.BloodGroup;
			domainServiceMongo.PostDonor(donor);
		}

		public DonorModel Find(int? id)
		{
			DonorModel DonorReturned = domainServiceMongo.Find(id);
			//IApplicationModelSQL applicationModelSQL = new ApplicationModelSQL
			//{

			//    DonorId = DonorReturned.DonorId,
			//    DonorName = DonorReturned.DonorName,
			//    BloodGroup = DonorReturned.BloodGroup
			//};

			return DonorReturned;
		}
		public void EditDonor(DonorModel donor)
		{
			//domainModelSQL.DonorId = applicationModelSQL.DonorId;
			//domainModelSQL.DonorName = applicationModelSQL.DonorName;
			//domainModelSQL.BloodGroup = applicationModelSQL.BloodGroup;
			domainServiceMongo.EditDonor(donor);
		}
		public void DeleteDonor(DonorModel donor)
		{
			//domainModelSQL.DonorId = applicationModelSQL.DonorId;
			//domainModelSQL.DonorName = applicationModelSQL.DonorName;
			//domainModelSQL.BloodGroup = applicationModelSQL.BloodGroup;
			domainServiceMongo.DeleteDonor(donor);
		}

	}
}