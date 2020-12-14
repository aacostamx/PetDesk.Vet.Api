using PetDesk.Vet.Api.Models;
using PetDesk.Vet.Api.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetDesk.Vet.Api.Manager
{
    public class AppointmentQuery : IAppointmentQuery
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentQuery(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public async Task<IEnumerable<Appointment>> Get()
        {
            return await _appointmentService.GetAppointments();
        }
    }
}
