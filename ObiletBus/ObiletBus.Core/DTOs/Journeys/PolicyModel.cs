using Newtonsoft.Json;

namespace ObiletBus.Core.DTOs.Journeys
{
    public class PolicyModel
    {
        [JsonProperty(PropertyName = "max-seats")]
        public int? max_seats { get; set; }
        [JsonProperty(PropertyName = "max-single")]
        public int? max_single { get; set; }
        [JsonProperty(PropertyName = "max-single-males")]
        public int? max_single_males { get; set; }
        [JsonProperty(PropertyName = "max-single-females")]
        public int? max_single_females { get; set; }
        [JsonProperty(PropertyName = "mixed-gender")]
        public bool mixed_gender { get; set; }
        [JsonProperty(PropertyName = "gov-id")]
        public bool gov_id { get; set; }
        public bool lht { get; set; }

    }
}
