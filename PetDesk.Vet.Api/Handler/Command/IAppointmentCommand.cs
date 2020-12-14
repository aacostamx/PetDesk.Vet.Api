using PetDesk.Vet.Api.Models;

namespace PetDesk.Vet.Api.Manager
{
    public interface IAppointmentCommand
    {
        void Insert(Appointment appointment);
    }
}
