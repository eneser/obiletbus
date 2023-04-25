using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ObiletBus.Core.DTOs.Location
{
    public class LocationDataDto
    {
        public int id { get; set; }

        [JsonPropertyName("parent-id")]
        //[System.Runtime.Serialization.DataMember(Name = "parent-id")]
        public int parent_id { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }
        public string name { get; set; }

        [JsonPropertyName("geo-location")]
        //[property: JsonPropertyName("geo-location")]
        public GeoLocation geo_location { get; set; }
        public int zoom { get; set; }
        [JsonPropertyName("tz-code")]
        public string tz_code { get; set; }
        [JsonPropertyName("weather-code")]
        public string weather_code { get; set; }
        public int? rank { get; set; }

        [JsonPropertyName("city-id")]
        public int city_id { get; set; }
        public string keywords { get; set; }
        [JsonPropertyName("country-id")]
        public int country_id { get; set; }
        public string languages { get; set; }
        [JsonPropertyName("area-code")]
        public string area_code { get; set; }
        [JsonPropertyName("city-name")]

        public string city_name { get; set; }
        [JsonPropertyName("country-name")]
        public string country_name { get; set; }
        [JsonPropertyName("show-country")]
        public bool show_country { get; set; }
        [JsonPropertyName("long-name")]
        public string long_name { get; set; }
    }
}
