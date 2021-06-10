using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Models.User
{
    public class UpdateUserDto
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("pwd")]
        public string Password { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
