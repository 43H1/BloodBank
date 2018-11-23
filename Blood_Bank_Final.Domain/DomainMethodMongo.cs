using Blood_Bank_Final.DataAccess.Abstract.Mongo;
using Blood_Bank_Final.Domain.Abstract;
using Blood_Bank_Final.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.Domain
{
	public class DomainMethodMongo : IDomainMethodMongo
	{
			IMongoMethods mongoMethods;

			public DomainMethodMongo(IMongoMethods mongoMethods)
			{
				this.mongoMethods = mongoMethods;
			}
			public List<DonorModel> GetDonors()
			{
				List<DonorModel> list = mongoMethods.GetDonors().ToList();
				return list;
			}
			public void PostDonor(DonorModel donor)
			{
				mongoMethods.PostDonor(donor);
			}
			public DonorModel Find(int? id)
			{
				DonorModel donor = GetDonors().Find(p => p.DonorId == id);
				return donor;
			}
			public void EditDonor(DonorModel donor)
			{
				mongoMethods.EditDonor(donor);
			}
			public void DeleteDonor(DonorModel donor)
			{
			
				mongoMethods.DeleteDonor(donor);
			}

		}
	}

