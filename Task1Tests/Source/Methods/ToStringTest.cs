using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Source.Tests;

namespace Task1Tests.Source.Methods
{
    [TestClass()]
    public class ToStringTest : InitializationTest
    {
        /// <summary>
        ///         CORRECT
        /// </summary>
        [TestMethod()]
        public void ToStringTest_Correct()
        {
            var expected = "hSpek, Дмитрий, Гирко, dmitriy_girko@mail.ru, 12-01-2022";
            var actual = _objUser.ToString();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///         NOTCORRECT
        /// </summary>
        [TestMethod()]
        public void ToString_NotCorrect()
        {
            var expected = "AndreyShchigolev, Андрей, Щиголев, AndreyShchigolev@mail.ru, 01-10-2022";
            var actual = _objUser.ToString();

            Assert.AreNotEqual(expected, actual);
        }
    }
}
