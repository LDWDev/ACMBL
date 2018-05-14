using System;
using ACMBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class LoggingTest
    {
        [TestMethod]
        public void CustomerLoggingTest()
        {
            //arrange
            var repository = new CustomerRepository();
            var expected="Customer name: " + "def, abc" + "\n" + "Order status: Active";
            var customer = repository.Retrieve(1);
            var customerList = new List<Customer>();
            customerList.Add(customer);
            //act
            //customer.Log();
            var actual = customer.Log();
            //Trace.WriteLine(actual);
            //Trace.ReadLine();
            //LoggingService.WriteToFile(customerList);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
