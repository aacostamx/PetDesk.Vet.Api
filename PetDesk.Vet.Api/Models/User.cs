using Newtonsoft.Json;

namespace PetDesk.Vet.Api.Models
{
    public class User
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("vetDataId")]
        public string VetDataId { get; set; }
    }
}
