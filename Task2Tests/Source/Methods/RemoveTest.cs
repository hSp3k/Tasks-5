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
    public class RemoveTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void Remove_Correct()
        {
            var expected = new int[] { 1, 3, 4 };

            _objDArraySide.Remove(2);

            CollectionAssert.AreEqual(expected, _objDArraySide);
        }

        [TestMethod()]
        public void Remove_CheckingCapacity_Correct()
        {
            var expected = 4;

            _objDArraySide.Remove(2);

            Assert.AreEqual(expected, _objDArraySide.Capacity);
        }

        [TestMethod()]
        public void Remove_CheckingLength_Correct()
        {
            var expected = 3;

            _objDArraySide.Remove(2);

            Assert.AreEqual(expected, _objDArraySide.Length);
        }
    }
}
