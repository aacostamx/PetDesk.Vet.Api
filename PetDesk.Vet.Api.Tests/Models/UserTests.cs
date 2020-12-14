namespace PetDesk.Vet.Api.Tests.Models
{
    using PetDesk.Vet.Api.Models;
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UserTests
    {
        private User _testClass;

        [TestInitialize]
        public void SetUp()
        {
            _testClass = new User();
        }

        [TestMethod]
        public void CanConstruct()
        {
            var instance = new User();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CanSetAndGetUserId()
        {
            var testValue = 18885424;
            _testClass.UserId = testValue;
            Assert.AreEqual(testValue, _testClass.UserId);
        }

        [TestMethod]
        public void CanSetAndGetFirstName()
        {
            var testValue = "TestValue1565517639";
            _testClass.FirstName = testValue;
            Assert.AreEqual(testValue, _testClass.FirstName);
        }

        [TestMethod]
        public void CanSetAndGetLastName()
        {
            var testValue = "TestValue360429676";
            _testClass.LastName = testValue;
            Assert.AreEqual(testValue, _testClass.LastName);
        }

        [TestMethod]
        public void CanSetAndGetVetDataId()
        {
            var testValue = "TestValue403547447";
            _testClass.VetDataId = testValue;
            Assert.AreEqual(testValue, _testClass.VetDataId);
        }
    }
}