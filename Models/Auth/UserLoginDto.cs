using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Models.Concrete.Dto
{
    public class UserLoginDto
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("pwd")]
        public string Password { get; set; }
    }
}
