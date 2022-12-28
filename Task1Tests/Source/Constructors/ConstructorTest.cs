using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Source.Tests;

namespace Task1Tests.Source.Constructors
{
    [TestClass()]
    public class ConstructorTest : InitializationTest
    {
        /// <summary>
        ///         CORRECT
        /// </summary>
        [TestMethod()]
        public void ConstructorTest_Correct()
        {
            Assert.AreEqual("Дмитрий", _objUser.Name);
            Assert.AreEqual("Гирко", _objUser.Surname);
            Assert.AreEqual("dmitriy_girko@mail.ru", _objUser.Email);
            Assert.AreEqual("hSpek", _objUser.Login);
            Assert.AreEqual(DateTime.Parse("21.11.2003"), _objUser.DateBirth);
            Assert.AreEqual(DateTime.Parse("12.01.2022"), _objUser.DateRegistration);
        }

        /// <summary>
        ///         NOTCORRECT
        /// </summary>
        [TestMethod()]
        public void ConstructorTest_NotCorrect()
        {
            Assert.AreNotEqual("Андрей", _objUser.Name);
            Assert.AreNotEqual("Щиголев", _objUser.Surname);
            Assert.AreNotEqual("AndreyShchigolev@mail.ru", _objUser.Email);
            Assert.AreNotEqual("AndreyShchigolev", _objUser.Login);
            Assert.AreNotEqual(DateTime.Parse("22.11.2004"), _objUser.DateBirth);
            Assert.AreNotEqual(DateTime.Parse("01.10.2022"), _objUser.DateRegistration);
        }
    }
}
