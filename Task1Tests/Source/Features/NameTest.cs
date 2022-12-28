using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Source.Tests;
using Task1.Source.CustomException;
using System.Text.RegularExpressions;
using Task1.Source.CustomException.ResourceException;
using System.Xml.Linq;

namespace Task1Tests.Source.Features
{
    [TestClass()]
    public class NameTest : InitializationTest
    {
        /// <summary>
        ///         CORRECT
        /// </summary>
        [TestMethod()]
        public void NameTest_CheckingSetAndGetMethods_Correct()
        {
            _objUser.Name = "Дмитрий";
            Assert.AreEqual("Дмитрий", _objUser.Name);
        }

        /// <summary>
        ///         NOTCORRECT
        /// </summary>
        [TestMethod()]
        public void NameTest_CheckingIsNullOrEmpty_NotCorrect()
        {
            var ex = Assert.ThrowsException<DataFormatException>(() =>
            {
                _objUser.Name = string.Empty;
            });
            var expected = $"Строка {nameof(_objUser.Name)} не может быть Пустой";

            Assert.AreEqual(expected, ex.Message);
        }
        [TestMethod()]
        public void NameTest_CheckingLength_NotCorrect()
        {
            var ex = Assert.ThrowsException<DataFormatException>(() =>
            {
                _objUser.Name = UtilityTest.CreateLine(NameLength + 1);
            });
            var expected = $"Длинна строки превышает {NameLength} символов";

            Assert.AreEqual(expected, ex.Message);
        }
        [TestMethod()]
        public void NameTest_CheckingIsMatch_NotCorrect()
        {
            var ex = Assert.ThrowsException<DataFormatException>(() =>
            {
                _objUser.Name = "W_Я";
            });
            var expected = MessageException.Name;

            Assert.AreEqual(expected, ex.Message);
        }
    }
}
