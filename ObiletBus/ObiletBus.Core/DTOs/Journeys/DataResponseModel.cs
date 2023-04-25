using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ObiletBus.Core.DTOs.Journeys
{
    public class DataResponseModel
    {
        public int id { get; set; }

        [JsonPropertyName("partner-id")]
        public int partner_id { get; set; }
        [JsonPropertyName("partner-name")]
        public string partner_name { get; set; }

        [JsonPropertyName("route-id")]
        public int route_id { get; set; }
        [JsonPropertyName("total-seats")]
        public int total_seats { get; set; }
        [JsonPropertyName("available-seats")]
        public int available_seats { get; set; }

        public JourneysModel journey { get; set; }
        public List<FeaturesModel> features { get; set; }

        [JsonPropertyName("origin-location")]
        public string origin_location { get; set; }

        [JsonPropertyName("destination-location")]
        public string destination_location { get; set; }

        [JsonPropertyName("origin-location-id")]
        public int origin_location_id { get; set; }
        [JsonPropertyName("destination-location-id")]
        public int destination_location_id { get; set; }

    }
}
