using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;

namespace WordPressTest
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void Admin_User_Can_Login()
        {
            var c = new LoginPage();
            c.Go();
          //  LoginPage.GoTo();
          //  LoginPage.LoginAs("admin").WithPassword("password").Login();
          //
          //  Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");

        }
    }
}
