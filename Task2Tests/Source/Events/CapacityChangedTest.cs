using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Task2.Source.Tests;
using Task2.Source.Events;

namespace Task2Tests.Source.Events
{
    [TestClass()]
    public class CapacityChangedTest : InitializationTest
    {
        // _objDArray = { };                Capacity = 2, Length = 0
        // _objDArraySide = { 1, 2, 3, 4 }; Capacity = 4, Length = 4

        public class TempClass
        {
            public object sender;
            public CapacityEventArgs e;
        }

        [TestMethod()]
        public void Capacity1_Correct()
        {
            var tempC = new TempClass();
            _objDArraySide.CapacityChanged += (sender, e) =>
            {
                tempC.sender = sender;
                tempC.e = e;
            };
            _objDArraySide.Add(100);

            Assert.AreEqual(tempC.sender, _objDArraySide);
            Assert.AreEqual(tempC.e.OldCapacity, 4);
            Assert.AreEqual(tempC.e.NewCapacity, 8);
        }

        public static void CapacityChanged(object sender, CapacityEventArgs e)
        {
            Console.WriteLine($"{e.GetType()} : {e.OldCapacity} -> {e.NewCapacity}");
        }
    }
}
