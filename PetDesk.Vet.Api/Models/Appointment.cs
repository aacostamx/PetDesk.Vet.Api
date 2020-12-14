using Newtonsoft.Json;
using System;

namespace PetDesk.Vet.Api.Models
{
    public class Appointment
    {
        [JsonProperty("appointmentId")]
        public int AppointmentId { get; set; }

        [JsonProperty("appointmentType")]
        public string AppointmentType { get; set; }

        [JsonProperty("createDateTime")]
        public DateTime CreateDateTime { get; set; }

        [JsonProperty("requestedDateTimeOffset")]
        public DateTimeOffset RequestedDateTimeOffset { get; set; }

        [JsonProperty("user_UserId")]
        public int UserUserId { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("animal_AnimalId")]
        public int AnimalAnimalId { get; set; }

        [JsonProperty("animal")]
        public Animal Animal { get; set; }
    }
}
