using Newtonsoft.Json;

namespace UniOtomasyonUI.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }

    }
}
