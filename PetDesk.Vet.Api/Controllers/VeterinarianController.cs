using Microsoft.AspNetCore.Mvc;
using PetDesk.Vet.Api.Manager;
using PetDesk.Vet.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetDesk.Vet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinarianController : ControllerBase
    {
        private readonly IAppointmentQuery _appointmentQuery;

        public VeterinarianController(IAppointmentQuery appointmentQuery)
        {
            _appointmentQuery = appointmentQuery;
        }

        [HttpGet]
        public async Task<IEnumerable<Appointment>> GetAppointmentsAsync()
        {
            return await _appointmentQuery.Get();
        }
    }
}
