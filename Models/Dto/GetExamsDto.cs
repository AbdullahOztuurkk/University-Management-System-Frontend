using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Models.Dto
{
    public class GetExamsDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
