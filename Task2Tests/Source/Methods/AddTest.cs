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
    public class AddTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void Add_NoChangeCapacity_CheckingCapacity_Correct()
        {
            var expected = 2;

            _objDArray.Add(1);

            Assert.AreEqual(expected, _objDArray.Capacity);
        }

        [TestMethod()]
        public void Add_NoChangeCapacity_CheckingLength_Correct()
        {
            var expected = 1;

            _objDArray.Add(1);

            Assert.AreEqual(expected, _objDArray.Length);
        }

        [TestMethod()]
        public void Add_ChangeCapacity_CheckingCapacity_Correct()
        {
            var expected = 8;

            _objDArraySide.Add(1);

            Assert.AreEqual(expected, _objDArraySide.Capacity);
        }

        [TestMethod()]
        public void Add_ChangeCapacity_CheckingLength_Correct()
        {
            var expected = 5;

            _objDArraySide.Add(1);

            Assert.AreEqual(expected, _objDArraySide.Length);
        }
    }
}
