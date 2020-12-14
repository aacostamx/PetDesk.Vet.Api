namespace PetDesk.Vet.Api.Tests.Models
{
    using PetDesk.Vet.Api.Models;
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AnimalTests
    {
        private Animal _testClass;

        [TestInitialize]
        public void SetUp()
        {
            _testClass = new Animal();
        }

        [TestMethod]
        public void CanConstruct()
        {
            var instance = new Animal();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CanSetAndGetAnimalId()
        {
            var testValue = 174373995;
            _testClass.AnimalId = testValue;
            Assert.AreEqual(testValue, _testClass.AnimalId);
        }

        [TestMethod]
        public void CanSetAndGetFirstName()
        {
            var testValue = "TestValue1563358479";
            _testClass.FirstName = testValue;
            Assert.AreEqual(testValue, _testClass.FirstName);
        }

        [TestMethod]
        public void CanSetAndGetSpecies()
        {
            var testValue = "TestValue995308820";
            _testClass.Species = testValue;
            Assert.AreEqual(testValue, _testClass.Species);
        }

        [TestMethod]
        public void CanSetAndGetBreed()
        {
            var testValue = "TestValue1496016691";
            _testClass.Breed = testValue;
            Assert.AreEqual(testValue, _testClass.Breed);
        }
    }
}