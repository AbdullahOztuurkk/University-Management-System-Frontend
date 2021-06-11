﻿using Newtonsoft.Json;
using System;

namespace UniOtomasyonUI.Models.Exam
{
    public class Exam
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("score")]
        public int Score { get; set; }
        [JsonProperty("announcementDate")]
        public DateTime announcementDate { get; set; }
        public ExamUserLesson UserLesson { get; set; }
    }

    public class ExamUserLesson
    {
        public Models.User.User user { get; set; }
        public Lesson.Lesson lesson { get; set; }
    }
}
