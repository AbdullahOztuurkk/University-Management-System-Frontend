using Newtonsoft.Json;

namespace UniOtomasyonUI.Models.UserLesson
{
    public class Lesson
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("credit")]
        public int Credit { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
