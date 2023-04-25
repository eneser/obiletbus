using Microsoft.AspNetCore.Mvc;
using ObiletBus.Core.DTOs.Session;
using ObiletBusWeb.IServices;
using ObiletBusWeb.Models;
using System.Diagnostics;

namespace ObiletBusWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISessionApiService _sessionApiService;

        public HomeController(ISessionApiService sessionApiService)
        {
            _sessionApiService = sessionApiService;
        }

        public async Task<IActionResult> Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("session-id")) && string.IsNullOrEmpty(HttpContext.Session.GetString("device-id")) )         
            {
                #region Session Model Set
                ApplicationDto application = new ApplicationDto
                {
                    equipment_id = "distribusion",
                    version = "1.0.0.0"
                };
                BrowserDto browser = new BrowserDto
                {
                    name = "Chrome",
                    version = "47.0.0.12"
                };
                ConnectionDto connect = new ConnectionDto
                {
                    ip_address = "192.168.1.93",
                    port = "0000"
                };

                GetSessionRequestDto model = new GetSessionRequestDto
                {
                    type = 7,
                    application = application,
                    browser = browser,
                    connection = connect
                };
                #endregion

                GetSessionResponseDto session = await _sessionApiService.GetSession(model);
                HttpContext.Session.SetString("session-id", session.data.session_id);
                HttpContext.Session.SetString("device-id", session.data.device_id);
            }

            return View();
        }

        public async Task<IActionResult> GetSession()
        {

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}