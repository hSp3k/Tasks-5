using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Source.Tests
{
    [TestClass()]
    public class InitializationTest
    {
        private protected User _objUser;

        private protected const int NameLength = 50;
        private protected const int SurnameLength = 200;
        private protected const int LoginLength = 20;

        [TestInitialize()]
        public void Initialization()
        {
            _objUser = new User("Дмитрий", "Гирко", DateTime.Parse("12.01.2022"), "hSpek");
            _objUser.DateBirth = DateTime.Parse("21.11.2003");
            _objUser.Email = "dmitriy_girko@mail.ru";
        }
    }
}