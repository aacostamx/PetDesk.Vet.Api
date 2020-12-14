namespace PetDesk.Vet.Api.Tests.Services
{
    using Microsoft.Extensions.Logging;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using PetDesk.Vet.Api.Models;
    using PetDesk.Vet.Api.Services;
    using System;
    using System.Net.Http;

    [TestClass]
    public class AppointmentServiceTests
    {
        private AppointmentService _testClass;
        private IHttpClientFactory _httpClientFactory;
        private ILogger<Appointment> _logger;

        [TestInitialize]
        public void SetUp()
        {
            _httpClientFactory = new Mock<IHttpClientFactory>().Object;
            _logger = new Mock<ILogger<Appointment>>().Object;
            _testClass = new AppointmentService(_httpClientFactory, _logger);
        }

        [TestMethod]
        public void CanConstruct()
        {
            var instance = new AppointmentService(_httpClientFactory, _logger);
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CannotConstructWithNullHttpClientFactory()
        {
            try
            {
                Assert.ThrowsException<ArgumentNullException>(() => new AppointmentService(default(IHttpClientFactory), new Mock<ILogger<Appointment>>().Object));
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CannotConstructWithNullLogger()
        {
            try
            {
                Assert.ThrowsException<ArgumentNullException>(() => new AppointmentService(new Mock<IHttpClientFactory>().Object, default(ILogger<Appointment>)));
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
    }
}