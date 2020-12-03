using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleShip.BL.Implementation.Class;

namespace Tests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void UserNameTest()
        {
            User TestUser = new User("TestName");
            string ExpectedName = "TestName";
            Assert.AreEqual(ExpectedName, TestUser.Name);
        }
    }
}
