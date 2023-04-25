using  Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ObiletBus.Core.DTOs.Session
{
    public class DataModel
    {
        [JsonPropertyName("session-id")]
        public string session_id { get; set; }

        [JsonPropertyName("device-id")]
        public string device_id { get; set; }
        public string affiliate { get; set; }

        [JsonPropertyName("device-type")]
        public int device_type { get; set; }
        public string device { get; set; }

        [JsonPropertyName("ip-country")]
        public string ip_country { get; set; }
    }
}
