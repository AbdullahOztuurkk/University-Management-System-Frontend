using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Models.UserLesson
{

    public class UserLesson
    {
        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("average")]
        public int Average { get; set; }

        [JsonProperty("lesson")]
        public Lesson Lesson { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }

        public string LessonName { get { return Lesson.Name; } }
    }


}
