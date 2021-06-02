using Newtonsoft.Json;

namespace UniOtomasyonUI.Models.Exam
{
    public class ExamLesson
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("code")]
        public string code { get; set; }
        [JsonProperty("credit")]
        public int credit { get; set; }
    }


}
