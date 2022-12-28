using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Source.Tests;

namespace Task2Tests.Source.Features
{
    [TestClass()]
    public class CapacityTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void Capacity_Correct()
        {
            var expected = 2;
            var actual = _objDArray.Capacity;

            Assert.AreEqual(expected, actual);
        }
    }
}
