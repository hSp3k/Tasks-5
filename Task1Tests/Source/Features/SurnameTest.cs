using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Source.Tests;
using System.Text.RegularExpressions;
using Task1.Source.CustomException;
using Task1.Source.CustomException.ResourceException;

namespace Task1Tests.Source.Features
{
    [TestClass()]
    public class SurnameTest : InitializationTest
    {
        /// <summary>
        ///         CORRECT
        /// </summary>
        [TestMethod()]
        public void SurnameTest_CheckingSetAndGetMethods_Correct()
        {
            _objUser.Surname = "Гирко";
            Assert.AreEqual("Гирко", _objUser.Surname);
        }

        /// <summary>
        ///         NOTCORRECT
        /// </summary>
        [TestMethod()]
        public void SurnameTest_CheckingIsNullOrEmpty_NotCorrect()
        {
            var ex = Assert.ThrowsException<DataFormatException>(() =>
            {
                _objUser.Surname = string.Empty;
            });
            var expected = $"Строка {nameof(_objUser.Surname)} не может быть Пустой";

            Assert.AreEqual(expected, ex.Message);
        }
        [TestMethod()]
        public void SurnameTest_CheckingLength_NotCorrect()
        {
            var ex = Assert.ThrowsException<DataFormatException>(() =>
            {
                _objUser.Surname = UtilityTest.CreateLine(SurnameLength + 1);
            });
            var expected = $"Длинна строки превышает {SurnameLength} символов.";

            Assert.AreEqual(expected, ex.Message);
        }
        [TestMethod()]
        public void SurnameTest_CheckingIsMatch_NotCorrect()
        {
            var ex = Assert.ThrowsException<DataFormatException>(() =>
            {
                _objUser.Surname = "W_Я";
            });
            var expected = MessageException.Surname;

            Assert.AreEqual(expected, ex.Message);
        }
    }
}
