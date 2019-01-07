using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleWebsite.Tests
{
    [TestClass]
    public class AuthenticationTests
    {
        [TestMethod]
        public void IsValidUserAuthObject_ValidUserAuthObject_ReturnTrue()
        {
            var userAuth = new UserAuth {Username = "user", Password = "pass"};

            var result = Website.IsValidUserAuthObject(userAuth);
            
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void IsValidUserAuthObject_StringObject_ReturnFalse()
        {
            var userAuth = new string("Not a userAuth obj");

            var result = Website.IsValidUserAuthObject(userAuth);
            
            Assert.IsFalse(result);
        }
        
    }
}