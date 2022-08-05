using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BLayer.Repositorys;
using ACM.BLayer;

namespace ACM.BLayerTest
{
   [TestClass()]
    public class ProductRepositoryTest
    {
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 350m,
                ProductDescription = "Set of 4 yellow mini flowers",
                ProductName = "sunFlowers"
            };
            var actual = productRepository.Retrive(2);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
        }
    }
}
