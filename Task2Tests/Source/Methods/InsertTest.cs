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
    public class InsertTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void Insert_Correct()
        {
            var expected = new int[] { 1, 10, 2, 3, 4 };

            _objDArraySide.Insert(10, 1);

            CollectionAssert.AreEqual(_objDArraySide, expected);
        }

        [TestMethod()]
        public void Insert_CheckingCapacity_Correct()
        {
            var expected = 8;

            _objDArraySide.Insert(10, 1);

            Assert.AreEqual(expected, _objDArraySide.Capacity);
        }

        [TestMethod()]
        public void Insert_CheckingLength_Correct()
        {
            var expected = 5;

            _objDArraySide.Insert(10, 1);

            Assert.AreEqual(expected, _objDArraySide.Length);
        }

        [TestMethod()]
        public void Insert_ThrowsException_NotCorrect()
        {
            var ex = Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                _objDArraySide.Insert(10, -1);
            });
        }
    }
}
