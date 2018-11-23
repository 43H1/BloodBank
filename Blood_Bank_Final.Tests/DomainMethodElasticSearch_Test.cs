using Blood_Bank_Final.DataAccess.ElasticSearch.Abstract;
using Blood_Bank_Final.Domain;
using Blood_Bank_Final.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.Tests
{
	[TestClass]
	public class DomainMethodElasticSearch_Test
	{
		private Mock<IElasticConfig> mockElasticConfig;
		private DomainMethodElasticSearch domainMethodElasticSearch;

		[TestMethod]
		public void PostTest_returns_ReturnedDonor()
		{
			//Arrange
			DonorModel donor = new DonorModel { DonorId = 1, DonorName = "donor", BloodGroup = "o+" };
			DonorModel donorReturned = new DonorModel { DonorId = 1, DonorName = "donor", BloodGroup = "o+" };
			mockElasticConfig = new Mock<IElasticConfig>(MockBehavior.Strict);
			mockElasticConfig.Setup(p => p.Post(donor)).Returns(donorReturned);
			domainMethodElasticSearch = new DomainMethodElasticSearch(mockElasticConfig.Object);

			//Act
			var returnedResult = domainMethodElasticSearch.Post(donor);

			//Assert
			Assert.AreEqual(donorReturned, returnedResult);

		}
	}
}
