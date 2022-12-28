using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Source.Tests;
using System.Text.RegularExpressions;
using Task1.Source.CustomException.ResourceException;
using Task1.Source.CustomException;
using System.Runtime.Intrinsics.X86;

namespace Task1Tests.Source.Features
{
    [TestClass()]
    public class EmailTest : InitializationTest
    {
        /// <summary>
        ///         CORRECT
        /// </summary>
        [DataTestMethod()]
        [DataRow("a@mail.ru")]
        [DataRow("alex@a.ru")]
        [DataRow("alex@aa.ss.dd.ff.gg.hh.jj.kk.ru")]
        public void EmailTest_CheckingSetAndGetMethods_Correct(string email)
        {
            _objUser.Email = email;
            Assert.AreEqual(email, _objUser.Email);
        }

        /// <summary>
        ///         NOTCORRECT
        /// </summary>
        [DataTestMethod()]
        [DataRow("_aa@mail.ru")]
        [DataRow("aa_@mail.ru")]
        [DataRow("aa@.ru")]
        [DataRow("aa@w..ru")]
        public void EmailTest_CheckingIsMatch_NotCorrect(string email)
        {
            var ex = Assert.ThrowsException<DataFormatException>(() =>
            {
                _objUser.Email = email;
            });

            var expected = MessageException.Email;

            Assert.AreEqual(expected, ex.Message);
        }
    }
}
