using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletBus.Core.DTOs.Location
{
    public class GetBusLocationResponseDto
    {
        public string status { get; set; }
        public List<LocationDataDto> data { get; set; }
    }
}
