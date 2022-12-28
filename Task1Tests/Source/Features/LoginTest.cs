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
    public class LoginTest : InitializationTest
    {
        /// <summary>
        ///         CORRECT
        /// </summary>
        [TestMethod()]
        public void LoginTest_CheckingSetAndGetMethods_Correct()
        {
            _objUser.Login = "hSpek";
            Assert.AreEqual("hSpek", _objUser.Login);
        }

        /// <summary>
        ///         NOTCORRECT
        /// </summary>
        [TestMethod()]
        public void LoginTest_CheckingIsNullOrEmpty_NotCorrect()
        {
            var ex = Assert.ThrowsException<DataFormatException>(() =>
            {
                _objUser.Login = string.Empty;
            });
            var expected = $"Строка {nameof(_objUser.Login)} не может быть Пустой";

            Assert.AreEqual(expected, ex.Message);
        }
        [TestMethod()]
        public void LoginTest_CheckingLength_NotCorrect()
        {
            var ex = Assert.ThrowsException<DataFormatException>(() =>
            {
                _objUser.Login = UtilityTest.CreateLine(LoginLength + 1);
            });
            var expected = $"Длина строки превышает {LoginLength} символов.";

            Assert.AreEqual(expected, ex.Message);
        }
        [TestMethod()]
        public void LoginTest_CheckingIsMatch_NotCorrect()
        {
            var ex = Assert.ThrowsException<DataFormatException>(() =>
            {
                _objUser.Login = "W_Я";
            });
            var expected = MessageException.Login;

            Assert.AreEqual(expected, ex.Message);
        }
    }
}
