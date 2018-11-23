using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.DataAccess.Mongo
{
	public class bloodDonor
	{
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
		public string BloodGroup { get; set; }
		public int DonorId { get; set; }
		public string DonorName { get; set; }
	}
}
