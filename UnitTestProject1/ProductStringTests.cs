using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ProductStringTests
    {
        [TestMethod]
        public void TestInsertSpaces()
        {
            //arrange
            var source = "SonicScrewDriver";
            var expected = "Sonic Screw Driver";
            //act
            var actual = source.InsertSpaces();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestExistingSpaces()
        {
            //arrange
            var source = "Sonic ScrewDriver";
            var expected = "Sonic Screw Driver";
            //act
            var actual = source.InsertSpaces();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
