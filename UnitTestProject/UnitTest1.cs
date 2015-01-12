using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnglishQuiz.SeleniumTests;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new Seltest();
            test.Go();
        }

        [TestMethod]
        public void User_Create_Login()
        {
            CreateLoginPage.GoTo();
            CreateLoginPage.CreateUserAs("bob@bob.com")
                .WithPassword("Foxtrot#123");

            Assert.IsTrue(HomePage.LoginMessage.Equals("Hello bob@bob.com!", "No logon."));


        }
    }
}
