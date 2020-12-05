using BattleShip.BL.Implementation.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
