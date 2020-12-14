namespace PetDesk.Vet.Api.Tests.Models
{
    using PetDesk.Vet.Api.Models;
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AppointmentTests
    {
        private Appointment _testClass;

        [TestInitialize]
        public void SetUp()
        {
            _testClass = new Appointment();
        }

        [TestMethod]
        public void CanConstruct()
        {
            var instance = new Appointment();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CanSetAndGetAppointmentId()
        {
            var testValue = 89654582;
            _testClass.AppointmentId = testValue;
            Assert.AreEqual(testValue, _testClass.AppointmentId);
        }

        [TestMethod]
        public void CanSetAndGetAppointmentType()
        {
            var testValue = "TestValue1523133955";
            _testClass.AppointmentType = testValue;
            Assert.AreEqual(testValue, _testClass.AppointmentType);
        }

        [TestMethod]
        public void CanSetAndGetCreateDateTime()
        {
            var testValue = new DateTime(1255017155);
            _testClass.CreateDateTime = testValue;
            Assert.AreEqual(testValue, _testClass.CreateDateTime);
        }

        [TestMethod]
        public void CanSetAndGetRequestedDateTimeOffset()
        {
            var testValue = new DateTimeOffset();
            _testClass.RequestedDateTimeOffset = testValue;
            Assert.AreEqual(testValue, _testClass.RequestedDateTimeOffset);
        }

        [TestMethod]
        public void CanSetAndGetUserUserId()
        {
            var testValue = 1712188367;
            _testClass.UserUserId = testValue;
            Assert.AreEqual(testValue, _testClass.UserUserId);
        }

        [TestMethod]
        public void CanSetAndGetUser()
        {
            var testValue = new User { UserId = 2039360704, FirstName = "TestValue723900361", LastName = "TestValue526769582", VetDataId = "TestValue410332521" };
            _testClass.User = testValue;
            Assert.AreEqual(testValue, _testClass.User);
        }

        [TestMethod]
        public void CanSetAndGetAnimalAnimalId()
        {
            var testValue = 842216553;
            _testClass.AnimalAnimalId = testValue;
            Assert.AreEqual(testValue, _testClass.AnimalAnimalId);
        }

        [TestMethod]
        public void CanSetAndGetAnimal()
        {
            var testValue = new Animal { AnimalId = 610411404, FirstName = "TestValue1357782348", Species = "TestValue1110138319", Breed = "TestValue138909648" };
            _testClass.Animal = testValue;
            Assert.AreEqual(testValue, _testClass.Animal);
        }
    }
}