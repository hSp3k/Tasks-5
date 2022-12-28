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
    public class IndexOfTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void IndexOf_Correct()
        {
            var expected = 0;

            Assert.AreEqual(expected, _objDArraySide.IndexOf(1));
        }

        [TestMethod()]
        public void Insert_NotCorrect()
        {
            var expected = -1;

            Assert.AreEqual(expected, _objDArraySide.IndexOf(100));
        }
    }
}
