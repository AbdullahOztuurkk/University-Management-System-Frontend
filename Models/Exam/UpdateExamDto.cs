using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Models.Exam
{
    public class UpdateExamDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("score")]
        public int Score { get; set; }
    }
}
