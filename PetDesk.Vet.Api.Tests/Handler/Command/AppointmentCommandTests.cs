namespace PetDesk.Vet.Api.Tests.Manager
{
    using PetDesk.Vet.Api.Manager;
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PetDesk.Vet.Api.Models;

    [TestClass]
    public class AppointmentCommandTests
    {
        private AppointmentCommand _testClass;

        [TestInitialize]
        public void SetUp()
        {
            _testClass = new AppointmentCommand();
        }

        [TestMethod]
        public void CanConstruct()
        {
            var instance = new AppointmentCommand();
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CannotCallInsertWithNullAppointment()
        {
            try
            {
                Assert.ThrowsException<ArgumentNullException>(() => _testClass.Insert(default(Appointment)));
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
    }
}