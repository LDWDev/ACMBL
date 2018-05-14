using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACMBL;
namespace ACMBLTest    
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
            FirstName = "abc",
            LastName = "def",
            EmailAddress = "abc@def.com"
            };

        //act
        var actual = customerRepository.Retrieve(1);

            //assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "abc",
                LastName = "def",
                EmailAddress = "abc@def.com",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot Row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                    },

                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
        };

         //act
         var actual = customerRepository.Retrieve(1);
            //assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.AddressList[0].StreetLine1, actual.AddressList[0].StreetLine1);
        }
    }
}
