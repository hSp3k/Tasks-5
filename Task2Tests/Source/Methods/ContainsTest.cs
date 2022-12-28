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
    public class ContainsTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void Contains_Correct()
        {
            Assert.IsTrue(_objDArraySide.Contains(1));
        }

        [TestMethod()]
        public void Contains_NotCorrect()
        {
            Assert.IsFalse(_objDArraySide.Contains(0));
        }
    }
}
