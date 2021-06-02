using Newtonsoft.Json;

namespace UniOtomasyonUI.Models.Exam
{
    public class ExamUser
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("Id")]
        public int Id { get; set; }
    }


}
