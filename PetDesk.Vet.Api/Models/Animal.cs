using Newtonsoft.Json;

namespace PetDesk.Vet.Api.Models
{
    public class Animal
    {
        [JsonProperty("animalId")]
        public int AnimalId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("breed")]
        public string Breed { get; set; }
    }
}
