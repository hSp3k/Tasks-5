using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task2Tests.Source.Constructors
{
    [TestClass()]
    public class CopyConstructorTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void CopyConstructor_Correct()
        {
            var tempArray = new int[] { 1, 1, 1, 1, 1 };

            var array = new DynamicArray<int>(tempArray);
            var expected = tempArray;

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod()]
        public void CopyConstructor_CheckingCapacity_Correct()
        {
            var tempArray = new int[] { 1, 1, 1, 1, 1 };

            var array = new DynamicArray<int>(tempArray);
            var expected = 8;

            Assert.AreEqual(expected, array.Capacity);
        }

        [TestMethod()]
        public void CopyConstructor_CheckingLength_Correct()
        {
            var tempArray = new int[] { 1, 1, 1, 1, 1 };

            var array = new DynamicArray<int>(tempArray);
            var expected = 5;

            Assert.AreEqual(expected, array.Length);
        }
    }
}
