using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Source.Tests;
using Task1.Source.CustomException;

namespace Task1Tests.Source.Features
{
    [TestClass()]
    public class DateRegistrationTest : InitializationTest
    {
        /// <summary>
        ///         CORRECT
        /// </summary>
        [TestMethod()]
        public void DateRegistrationTest_CheckingSetAndGetMethods_Correct()
        {
            _objUser.DateRegistration = DateTime.Parse("01.01.2020");
            Assert.AreEqual(DateTime.Parse("01.01.2020"), _objUser.DateRegistration);
        }

        /// <summary>
        ///         NOTCORRECT
        /// </summary>
        [TestMethod()]
        public void DateRegistrationTest_CheckingGettingThrows_NotCorrect()
        {
            var ex = Assert.ThrowsException<DateException>(() =>
            {
                _objUser.DateRegistration = DateTime.Parse("01.01.1000");
            });

            var expected = "Дата Регистрации не может быть меньше Даты Рождения";

            Assert.AreEqual(expected, ex.Message);
        }
    }
}
