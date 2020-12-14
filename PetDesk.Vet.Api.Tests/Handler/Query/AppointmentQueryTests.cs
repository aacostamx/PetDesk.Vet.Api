namespace PetDesk.Vet.Api.Tests.Manager
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using PetDesk.Vet.Api.Manager;
    using PetDesk.Vet.Api.Services;
    using System;

    [TestClass]
    public class AppointmentQueryTests
    {
        private AppointmentQuery _testClass;
        private IAppointmentService _appointmentService;

        [TestInitialize]
        public void SetUp()
        {
            _appointmentService = new Mock<IAppointmentService>().Object;
            _testClass = new AppointmentQuery(_appointmentService);
        }

        [TestMethod]
        public void CanConstruct()
        {
            var instance = new AppointmentQuery(_appointmentService);
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CannotConstructWithNullAppointmentService()
        {
            try
            {
                Assert.ThrowsException<ArgumentNullException>(() => new AppointmentQuery(default(IAppointmentService)));
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
    }
}