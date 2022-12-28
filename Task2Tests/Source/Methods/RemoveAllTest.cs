using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Task2.Source.Tests;

namespace Task2Tests.Source.Methods
{
    [TestClass()]
    public class RemoveAllTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void RemoveAll_Correct()
        {
            var expected = new int[3] { 2, 3, 4 };

            _objDArraySide.RemoveAll(1);

            CollectionAssert.AreEqual(expected, _objDArraySide);
        }

        [TestMethod()]
        public void RemoveAll_CheckingCapacity_Correct()
        {
            var expected = 4;

            _objDArraySide.RemoveAll(1);

            Assert.AreEqual(expected, _objDArraySide.Capacity);
        }

        [TestMethod()]
        public void RemoveAll_CheckingLength_Correct()
        {
            var expected = 3;

            _objDArraySide.RemoveAll(1);

            Assert.AreEqual(expected, _objDArraySide.Length);
        }
    }
}
