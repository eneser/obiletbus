using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ObiletBus.Core.DTOs.Journeys
{
    public class DataRequestModel
    {
        [JsonProperty(PropertyName = "origin-id")]
        public int orgin_id { get; set; }

        [JsonProperty(PropertyName = "destination-id")]
        public int destination_id { get; set; }

        [JsonProperty(PropertyName = "departure-date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime departure_date { get; set; }
    }
}
