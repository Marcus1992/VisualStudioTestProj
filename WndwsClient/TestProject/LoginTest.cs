using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryClass;

namespace TestProject
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string username = "rrea";
            string password = Convert.ToString(123);
            bool Access2;
            //ConnectClass.checkLogin(username, password);
            
            //ConnectClass.AddUser("Marc", "123", "Debnarj", 474242);
            //Assert.Equals(username, ConnectClass.passU);
            //Assert.AreEqual(cnc, (username));
           // Assert.AreEqual(cnc, password);
        }
    }
}
