using Microsoft.AspNetCore.Mvc;
using ObiletBus.Core.DTOs.DeviceSession;
using ObiletBus.Core.DTOs.Journeys;
using ObiletBusWeb.IServices;

namespace ObiletBusWeb.Controllers
{
    public class JourneysController : Controller
    {
        private readonly IJourneysApiService _journeysApiService;

        public JourneysController(IJourneysApiService journeysApiService)
        {
            _journeysApiService = journeysApiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Seferler(int orgin,int destination, string departuredate)
        {
            var date =Convert.ToDateTime(departuredate);
            DataRequestModel data = new DataRequestModel
            {
                departure_date = date,
                destination_id = destination,
                orgin_id = orgin
            };
            DeviceSessionDto deviceSession = new DeviceSessionDto
            {
                session_id = HttpContext.Session.GetString("session-id"),
                device_id = HttpContext.Session.GetString("device-id")
            };
            JourneysRequestDto request = new JourneysRequestDto
            {
                data = data,
                device_session = deviceSession,
                date = date,
                language = "en-EN"

            };

            var response = await _journeysApiService.GetBusJourneys(request);

            return View(response);
        }
    }
}
