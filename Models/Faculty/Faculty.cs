using Newtonsoft.Json;

namespace UniOtomasyonUI.Models.Faculty
{
    public class Faculty
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slugifyName")]
        public string SlugifyName { get; set; }
    }

}
