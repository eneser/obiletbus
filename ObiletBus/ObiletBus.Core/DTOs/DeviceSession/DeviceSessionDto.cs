using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletBus.Core.DTOs.DeviceSession
{
    public class DeviceSessionDto
    {

        [JsonProperty(PropertyName = "session-id")]
        public string session_id { get; set; }

        [JsonProperty(PropertyName = "device-id")]
        public string device_id { get; set; }
    }
}
