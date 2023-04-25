using Newtonsoft.Json;
using ObiletBus.Core.DTOs.DeviceSession;
using System.ComponentModel.DataAnnotations;

namespace ObiletBus.Core.DTOs.Journeys
{
    public class JourneysRequestDto
    {
        [JsonProperty(PropertyName = "device-session")]
        public DeviceSessionDto device_session { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime date { get; set; }
        public string language { get; set; }
        public DataRequestModel data { get; set; }
        


    }
}
