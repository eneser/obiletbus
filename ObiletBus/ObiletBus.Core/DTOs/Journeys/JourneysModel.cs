using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ObiletBus.Core.DTOs.Journeys
{
    public class JourneysModel
    {
        public string kind { get; set; }
        public string code { get; set; }
        public List<StopsModel> stops { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime departure { get; set; }
        public DateTime arrival { get; set; }
        public string currency { get; set; }
        [JsonPropertyName("original-price")]
        public decimal original_price { get; set; }
        [JsonPropertyName("internet-price")]
        public decimal internet_price { get; set; }
        public PolicyModel policy { get; set; }
        public string[] features { get; set; }
        public int? available { get; set; }

    }
}
