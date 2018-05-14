using System;
using ACMBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACBMLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //arrange
            Customer customer = new Customer();
            //act
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            string expected = "Baggins, Bilbo";
            //assert
            Assert.AreEqual(customer.FullName, expected);
        }

        [TestMethod]
        public void FullNameAndEmailTestValid()
        {
            //arrange
            Customer customer = new Customer();
            bool expected = true;
            //act
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            customer.EmailAddress = "asdf";
            //assert
            Assert.AreEqual(customer.Validate(), expected);
        }

    }
}
