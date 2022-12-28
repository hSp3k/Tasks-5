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
    public class IndexerTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void Indexer_Correct()
        {
            var expected = 1;

            Assert.AreEqual(expected, _objDArraySide[0]);
        }

        [TestMethod()]
        public void Indexer_ThrowException_NotCorrect()
        {
            var ex = Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                var item = _objDArray[-1];
            });
        }
    }
}
