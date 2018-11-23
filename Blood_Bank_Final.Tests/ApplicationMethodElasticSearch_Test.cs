using Blood_Bank_Final.Application;
using Blood_Bank_Final.Domain.Abstract;
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
	public class ApplicationMethodElasticSearch_Test
	{
		private Mock<IDomainMethodElasticSearch> mockDomainMethodElasticSearch;
		private ApplicationMethodElasticSearch applicationMethodElasticTest;

		[TestMethod]
		public void PostTest_returns_ReturnedDonor()
		{
			//Arrange
			DonorModel donor = new DonorModel { DonorId = 13, DonorName = "testname", BloodGroup = "testgroup" };
			DonorModel donorReturned = new DonorModel { DonorId = 3, DonorName = "testname", BloodGroup = "testgroup" };
			mockDomainMethodElasticSearch = new Mock<IDomainMethodElasticSearch>(MockBehavior.Strict);
			mockDomainMethodElasticSearch.Setup(p => p.Post(donor)).Returns(donorReturned);
			applicationMethodElasticTest = new ApplicationMethodElasticSearch(mockDomainMethodElasticSearch.Object);

			//Act
			var result = applicationMethodElasticTest.Post(donor);

			//Assert
			Assert.AreEqual(result, donorReturned);
			mockDomainMethodElasticSearch.VerifyAll();
		}

	}
}
