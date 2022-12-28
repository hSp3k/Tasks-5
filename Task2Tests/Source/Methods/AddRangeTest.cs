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
    public class AddRangeTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void AddRange_NoChangeCapacity_CheckingCapacity_Correct()
        {
            var array = new int[] { 1 };
            var expected = 2;

            _objDArray.AddRange(array);

            Assert.AreEqual(expected, _objDArray.Capacity);
        }

        [TestMethod()]
        public void AddRange_NoChangeCapacity_CheckingLength_Correct()
        {
            var array = new int[] { 1 };
            var expected = 1;

            _objDArray.AddRange(array);

            Assert.AreEqual(expected, _objDArray.Length);
        }

        [TestMethod()]
        public void AddRange_ChangeCapacity_CheckingCapacity_Correct()
        {
            var array = new int[] { 1, 1, 1 };
            var expected = 4;

            _objDArray.AddRange(array);

            Assert.AreEqual(expected, _objDArray.Capacity);
        }

        [TestMethod()]
        public void AddRange_ChangeCapacity_CheckingLength_Correct()
        {
            var array = new int[] { 1, 1, 1 };
            var expected = 3;

            _objDArray.AddRange(array);

            Assert.AreEqual(expected, _objDArray.Length);
        }
    }
}
