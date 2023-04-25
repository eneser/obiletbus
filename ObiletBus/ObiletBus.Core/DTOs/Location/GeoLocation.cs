using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletBus.Core.DTOs.Location
{
    public class GeoLocation
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int zoom { get; set; }
    }
}
