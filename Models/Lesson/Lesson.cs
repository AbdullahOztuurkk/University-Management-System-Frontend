using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Models.Lesson
{
    public class Lesson
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("credit")]
        public int Credit { get; set; }
    }
}
