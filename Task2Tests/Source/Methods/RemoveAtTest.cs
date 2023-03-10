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
    public class RemoveAtTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void RemoveAt_Correct()
        {
            var expected = new int[] { 1, 3, 4 };

            _objDArraySide.RemoveAt(1);

            CollectionAssert.AreEqual(expected, _objDArraySide);
        }

        [TestMethod()]
        public void RemoveAt_CheckingCapacity_Correct()
        {
            var expected = 4;

            _objDArraySide.RemoveAt(1);

            Assert.AreEqual(expected, _objDArraySide.Capacity);
        }

        [TestMethod()]
        public void RemoveAt_CheckingLength_Correct()
        {
            var expected = 3;

            _objDArraySide.RemoveAt(1);

            Assert.AreEqual(expected, _objDArraySide.Length);
        }

        [TestMethod()]
        public void RemoveAt_ThrowsException_NotCorrect()
        {
            var ex = Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                _objDArraySide.RemoveAt(-1);
            });
        }
    }
}
