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
    public class ExtractingDataTest : InitializationTest
    {
        /// <summary>
        ///         CORRECT
        /// </summary>
        [DataTestMethod()]
        [DataRow("hSpek, Дмитрий, Гирко, dmitriy_girko@mail.ru, 21.11.2003")]
        public void ExtractingDataTest_Correct(string line)
        {
            var expected = "hSpek, Дмитрий, Гирко, dmitriy_girko@mail.ru, 21.11.2003";

            Assert.AreEqual(expected, line);
        }

        /// <summary>
        ///         NOTCORRECT
        /// </summary>
        [DataTestMethod()]
        [DataRow("AndreyShchigolev, Андрей, Щиголев, AndreyShchigolev@mail.ru, 22.11.2004")]
        public void ExtractingDataTest_NotCorrect(string line)
        {
            var expected = "hSpek, Дмитрий, Гирко, dmitriy_girko@mail.ru, 21.11.2003";

            Assert.AreNotEqual(expected, line);
        }
    }
}
