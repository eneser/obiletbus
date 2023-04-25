using Newtonsoft.Json;

namespace ObiletBus.Core.DTOs.Session
{
    public class ApplicationDto
    {
        public string version { get; set; }

        [JsonProperty(PropertyName = "equipment-id")]
        public string equipment_id { get; set; }
    }
}
