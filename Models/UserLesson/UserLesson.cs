﻿using Newtonsoft.Json;

namespace UniOtomasyonUI.Models.UserLesson
{
    public class UserLesson
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("average")]
        public int Average { get; set; }

        [JsonProperty("lesson")]
        public Lesson.Lesson Lesson { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }

        public string LessonName { get { return Lesson.Name; } }
    }
}
