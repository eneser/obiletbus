using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ObiletBus.Core.DTOs.DeviceSession;
using ObiletBus.Core.DTOs.Location;
using ObiletBusWeb.IServices;
using System.Diagnostics;

namespace ObiletBusWeb.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationApiService _locationApiService;
        private IMemoryCache _memoryCache;
        public LocationController(ILocationApiService locationApiService, IMemoryCache memoryCache)
        {
            _locationApiService = locationApiService;
            _memoryCache = memoryCache;
        }
        [HttpPost]
        public async Task<IActionResult> GetBusLocation(string data)
        {
             GetBusLocationResponseDto response = new GetBusLocationResponseDto();
            if (_memoryCache.Get<GetBusLocationResponseDto>("buslocation") == null)
            {
                DeviceSessionDto deviceSession = new DeviceSessionDto
                {
                    session_id = HttpContext.Session.GetString("session-id"),
                    device_id = HttpContext.Session.GetString("device-id")
                };
                GetBusLocationRequestDto request = new GetBusLocationRequestDto
                {
                    data = data,
                    date = DateTime.Now,
                    device_session = deviceSession,
                    language = "en-EN"
                };

                response = await _locationApiService.GetBusLocation(request);
                _memoryCache.Set<GetBusLocationResponseDto>("buslocation", response);
            }
            else
                response = _memoryCache.Get<GetBusLocationResponseDto>("buslocation");

            GetBusLocationResponseDto locations = new GetBusLocationResponseDto();
            locations.status = response.status;

            if (data != null)
                locations.data = response.data.Where(x => x.name.ToLower().Contains(data.ToLower())).Take(5).ToList();
            else
                locations.data = response.data.Take(5).ToList();

            return Json(locations);
        }
    }
}
