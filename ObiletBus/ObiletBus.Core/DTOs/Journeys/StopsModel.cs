using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletBus.Core.DTOs.Journeys
{
    public class StopsModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string station { get; set; }
        public DateTime? time { get; set; }
        [JsonProperty(PropertyName = "is-origin")]
        public bool is_origin { get; set; }
        [JsonProperty(PropertyName = "is-destination")]
        public bool is_destination { get; set; }
    }
}
