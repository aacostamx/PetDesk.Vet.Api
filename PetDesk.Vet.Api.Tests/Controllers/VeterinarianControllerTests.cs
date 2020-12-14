using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PetDesk.Vet.Api.Controllers;
using PetDesk.Vet.Api.Manager;
using PetDesk.Vet.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetDesk.Vet.Api.Tests.Controllers
{
    [TestClass]
    public class VeterinarianControllerTests
    {
        private MockRepository mockRepository;

        private Mock<IAppointmentQuery> mockAppointmentQuery;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockAppointmentQuery = this.mockRepository.Create<IAppointmentQuery>();
        }

        private VeterinarianController CreateVeterinarianController()
        {
            return new VeterinarianController(
                this.mockAppointmentQuery.Object);
        }

        [TestMethod]
        public async Task GetAppointmentsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var veterinarianController = this.CreateVeterinarianController();

            mockAppointmentQuery.Setup(c => c.Get())
                .ReturnsAsync(new List<Appointment>());

            // Act
            var result = await veterinarianController.GetAppointmentsAsync();

            // Assert
            Assert.IsNotNull(result);
            this.mockRepository.VerifyAll();
        }
    }
}
