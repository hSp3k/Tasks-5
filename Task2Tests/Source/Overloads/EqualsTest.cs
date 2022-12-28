using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Task2.Source.Tests;

namespace Task2Tests.Source.Overloads
{
    [TestClass()]
    public class EqualsTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void Equals_Correct()
        {
            var tempArray = new int[] { 1, 2, 3, 4 };
            var array = new DynamicArray<int>(tempArray);

            Assert.IsTrue(_objDArraySide.Equals(array));
        }

        [TestMethod()]
        public void Equals_NotCorrect()
        {
            var tempArray = new int[] { 2, 2, 3, 3 };
            var array = new DynamicArray<int>(tempArray);

            Assert.IsFalse(_objDArraySide.Equals(array));
        }
    }
}
