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
    public class DefaultConstructorTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void DefaultConstructor_Correct()
        {
            var array = new DynamicArray<int>();
            var expected = new int[0];

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod()]
        public void DefaultConstructor_CheckingCapacity_Correct()
        {
            var array = new DynamicArray<int>();
            var expected = 8;

            Assert.AreEqual(expected, array.Capacity);
        }

        [TestMethod()]
        public void DefaultConstructor_CheckingLength_Correct()
        {
            var array = new DynamicArray<int>();
            var expected = 0;

            Assert.AreEqual(expected, array.Length);
        }
    }
}
