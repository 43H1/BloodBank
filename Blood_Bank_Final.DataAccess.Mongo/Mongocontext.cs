using Blood_Bank_Final.DataAccess.Mongo.Properties;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.DataAccess.Mongo
{
    public class Mongocontext
    {
		public IMongoDatabase database;
		public Mongocontext()
		{
			var connectionString = Settings.Default.ConnectionString;
			var settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
			var client = new MongoClient(settings);
			database = client.GetDatabase(Settings.Default.DatabaseName);
		}

		//public IMongoCollection<Batch> Get => database.GetCollection<Batch>("Batch");
		public IMongoCollection<bloodDonor> mongoCollection => database.GetCollection<bloodDonor>("bloodDonor");
	}
}
