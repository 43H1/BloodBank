using Blood_Bank_Final.DataAccess.ElasticSearch.Abstract;
using Blood_Bank_Final.Infrastructure;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.DataAccess.ElasticSearch
{
	public class ElasticConfig : IElasticConfig
	{
		ElasticClient client = null;
		public ElasticConfig()
		{
			var settings = new ConnectionSettings(new Uri("http://localhost:9200")).DefaultIndex("bloodbank");

			client = new ElasticClient(settings);
		}
		public DonorModel Post(DonorModel donor)
		{
			var request = new IndexRequest<DonorModel>(donor) { };

			var indexResponse = client.Index<DonorModel>(request);
			return donor;
		}


		public List<DonorModel> GetAll(string searchString)
		{
			var searchResponse = client.Search<DonorModel>(s => s
				.From(0)
				.Size(10)
				.Query(q => q
					 .Match(m => m
						.Field(f => f.BloodGroup)
						.Query(searchString)
					 )
				)
			);

			return searchResponse.Documents.ToList();
		}
	}
}