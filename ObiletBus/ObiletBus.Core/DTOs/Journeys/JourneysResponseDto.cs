using Newtonsoft.Json;

namespace ObiletBus.Core.DTOs.Journeys
{
    public class JourneysResponseDto
    {
        public string status { get; set; }
        public List<DataResponseModel> data { get; set; }
        public string message { get; set; }

        [JsonProperty(PropertyName = "user-message")]
        public string user_message { get; set; }

        [JsonProperty(PropertyName = "api-request-id")]
        public string api_request_id { get; set; }

        public string controller { get; set; }
    }
}
