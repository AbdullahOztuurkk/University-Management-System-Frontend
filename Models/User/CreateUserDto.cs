using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Models.User
{
    public class CreateUserDto
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Role { get; set; }
        [JsonProperty("pwd")]
        public string Password { get; set; }
        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }
    }
}
