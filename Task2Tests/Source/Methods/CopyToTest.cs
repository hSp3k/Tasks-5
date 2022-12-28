using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Source.Tests;

namespace Task2Tests.Source.Methods
{
    [TestClass()]
    public class CopyToTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        [TestMethod()]
        public void CopyTo_Correct()
        {
            var expected = new int[] { 1, 2, 3, 4 };

            var array = new int[4];
            _objDArraySide.CopyTo(array, 0);

            CollectionAssert.AreEqual(expected, _objDArraySide);
        }

        [TestMethod()]
        public void CopyTo_ThrowsException_Correct()
        {
            var array = new int[0];
            var expected = "";

            var ex = Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                _objDArraySide.CopyTo(array, 10);
            });
            // Assert.AreEqual(expected, ex.Message);
        }
    }
}
