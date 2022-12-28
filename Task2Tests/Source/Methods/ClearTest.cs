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
    public class ClearTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void Clear_CheckingCapacity_Correct()
        {
            var expected = 4;

            _objDArraySide.Clear();

            Assert.AreEqual(expected, _objDArraySide.Capacity);
        }

        [TestMethod()]
        public void Clear_CheckingLength_Correct()
        {
            var expected = 0;

            _objDArraySide.Clear();

            Assert.AreEqual(expected, _objDArraySide.Length);
        }
    }
}
