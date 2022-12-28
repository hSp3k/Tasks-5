using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Task2.Source.Tests;

namespace Task2Tests.Source.Interfaces
{
    [TestClass()]
    public class IEnumerableTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void IEnumerable_Correct()
        {
            var array = new int[] { 1, 2, 3, 4 };

            int indx = 0;
            foreach (var item in _objDArraySide)
            {
                Assert.AreEqual(array[indx], item);
                indx++;
            }
        }
    }
}
