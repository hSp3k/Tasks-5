﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Task2.Source.Tests;

namespace Task2Tests.Source.TypeConversion
{
    [TestClass()]
    public class DynamicArrayToArrayTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void DynamicArrayToArray_Correct()
        {
            var expected = new int[] { 1, 2, 3, 4 };

            int[] array = _objDArraySide;

            CollectionAssert.AreEqual(array, expected);
        }
    }
}
