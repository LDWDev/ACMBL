using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACMBL;
namespace ProductRepositoryTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var expected = "Sunflowers";
            var actual = new Product();
            var dummyRepository = new ProductRepository();
            //act
            actual = dummyRepository.Retrieve(2);
            //assert
            Assert.AreEqual(expected, actual.ProductName);
        }
    }
}
