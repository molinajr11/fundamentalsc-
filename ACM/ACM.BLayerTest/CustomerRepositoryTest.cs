using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BLayer;
using ACM.BLayer.Repositorys;

namespace ACM.BLayerTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Costumer(1)
            {
                EmailAddress = "fbaggis@hobbit.me",
                FirstName = "froodo",
                LastName = "Baggins"
            };
            var actual = customerRepository.Retrive(1);

            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
