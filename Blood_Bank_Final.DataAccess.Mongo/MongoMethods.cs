using Blood_Bank_Final.DataAccess.Abstract.Mongo;
using Blood_Bank_Final.Infrastructure;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.DataAccess.Mongo
{
	public class MongoMethods: IMongoMethods
	{
		Mongocontext mongocontext = new Mongocontext();
		public List<DonorModel> GetDonors()
		{
			IQueryable<bloodDonor> donors = mongocontext.mongoCollection.AsQueryable();
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
		public void PostDonor(DonorModel bloodDonor)
		{
			bloodDonor _bloodDonor = new bloodDonor
			{
				DonorId = bloodDonor.DonorId,
				DonorName = bloodDonor.DonorName,
				BloodGroup = bloodDonor.BloodGroup
			};
			mongocontext.mongoCollection.InsertOne(_bloodDonor);
		}
		public void EditDonor(DonorModel bloodDonor)
		{
			bloodDonor _bloodDonor = new bloodDonor
			{
				DonorId = bloodDonor.DonorId,
				DonorName = bloodDonor.DonorName,
				BloodGroup = bloodDonor.BloodGroup
			};
			mongocontext.mongoCollection.FindOneAndUpdate(p => p.DonorId == _bloodDonor.DonorId,
				 Builders<bloodDonor>.Update.Set("DonorName", _bloodDonor.DonorName));
			mongocontext.mongoCollection.FindOneAndUpdate(p => p.DonorId == _bloodDonor.DonorId,
				Builders<bloodDonor>.Update.Set("BloodGroup", _bloodDonor.BloodGroup));

		}
		public void DeleteDonor(DonorModel bloodDonor)
		{
			bloodDonor _bloodDonor = new bloodDonor
			{
				DonorId = bloodDonor.DonorId,
				DonorName = bloodDonor.DonorName,
				BloodGroup = bloodDonor.BloodGroup
			};
			mongocontext.mongoCollection.DeleteOne(p=>p.DonorId ==_bloodDonor.DonorId);

		}
	}
}
