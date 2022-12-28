using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Source.Tests
{
    [TestClass()]
    public class InitializationTest
    {
        private protected DynamicArray<int> _objDArray;
        private protected DynamicArray<int> _objDArraySide;

        [TestInitialize()]
        public void Initialization()
        {
            _objDArray = new DynamicArray<int>(2);
            _objDArraySide = new DynamicArray<int>(new int[] { 1, 2, 3, 4 });

            // _objDArray = { };                Capacity = 2, Length = 0
            // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4
        }
    }
}