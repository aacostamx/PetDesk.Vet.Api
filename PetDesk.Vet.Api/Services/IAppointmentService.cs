using PetDesk.Vet.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetDesk.Vet.Api.Services
{
    public interface IAppointmentService
    {
        Task<IEnumerable<Appointment>> GetAppointments();
    }
}
