using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Models.Department
{
    public class Department
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slugifyName")]
        public string SlugifyName { get; set; }
    }
}
