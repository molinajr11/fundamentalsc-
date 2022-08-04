using ACM.BLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLayerTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Costumer customer = new Costumer
            {
                FirstName = "Baggins",
                LastName = "Bilbo"
            };
            string expected = "Bilbo, Baggins";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Costumer customer = new Costumer
            {
                FirstName = "Bilbo",
            };
            string expected = "Bilbo";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Costumer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };
            var expected = true;
            var actual=customer.validate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Costumer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };
            var expected = false;
            var actual = customer.validate();
            Assert.AreEqual(expected, actual);
        }
    }
}
