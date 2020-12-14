using PetDesk.Vet.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetDesk.Vet.Api.Manager
{
    public interface IAppointmentQuery
    {
        Task<IEnumerable<Appointment>> Get();
    }
}
