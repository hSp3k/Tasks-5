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
    public class DateBirthTest : InitializationTest
    {
        /// <summary>
        ///         CORRECT
        /// </summary>
        [TestMethod()]
        public void DateBirthTest_CheckingSetAndGetMethods_Correct()
        {
            _objUser.DateBirth = DateTime.Parse("01.01.2020");
            Assert.AreEqual(DateTime.Parse("01.01.2020"), _objUser.DateBirth);
        }

        /// <summary>
        ///         NOTCORRECT
        /// </summary>
        [TestMethod()]
        public void DateBirthTest_CheckingGettingThrows_NotCorrect()
        {
            var ex = Assert.ThrowsException<DateException>(() =>
            {
                _objUser.DateBirth = DateTime.Parse("01.01.5000");
            });

            var expected = "Дата Рождения не может быть больше Даты Регистрации";

            Assert.AreEqual(expected, ex.Message);
        }
    }
}
