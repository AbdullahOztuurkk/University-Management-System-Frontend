using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Models.Exam
{
    public class DeleteExamDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
