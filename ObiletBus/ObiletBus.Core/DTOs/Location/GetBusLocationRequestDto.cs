using Newtonsoft.Json;
using ObiletBus.Core.DTOs.DeviceSession;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletBus.Core.DTOs.Location
{
    public class GetBusLocationRequestDto
    {
        [JsonProperty(PropertyName = "data")]
        public string data { get; set; }

        [JsonProperty(PropertyName = "device-session")]
        public DeviceSessionDto device_session { get; set; }
        [JsonProperty(PropertyName = "date")]
        public DateTime date { get; set; }
        [JsonProperty(PropertyName = "language")]
        public string language { get; set; }
    }
}
