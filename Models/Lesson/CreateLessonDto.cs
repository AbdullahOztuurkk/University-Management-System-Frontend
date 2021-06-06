using Newtonsoft.Json;

namespace UniOtomasyonUI.Models.Lesson
{
    public class CreateLessonDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credit")]
        public int Credit { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("grade")]
        public int Grade { get; set; }
    }
}
