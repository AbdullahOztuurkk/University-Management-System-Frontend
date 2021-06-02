using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Models.Exam
{
    public class Exam
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("score")]
        public int Score { get; set; }
        [JsonProperty("announcementDate")]
        public DateTime announcementDate { get; set; }
        public ExamUserLesson UserLesson { get; set; }
    }

}
