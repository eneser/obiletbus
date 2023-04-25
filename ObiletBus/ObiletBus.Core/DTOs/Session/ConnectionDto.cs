using Newtonsoft.Json;

namespace ObiletBus.Core.DTOs.Session
{
    public class ConnectionDto
    {
        [JsonProperty(PropertyName = "ip-address")]

        public string ip_address { get; set; } 
        public string port { get; set; } 
    }
}
