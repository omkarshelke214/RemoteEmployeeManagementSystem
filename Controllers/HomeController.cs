using Microsoft.AspNetCore.Mvc;
using RemoteEmpoyeeManagementSystem.Models;
using System.Diagnostics;

namespace RemoteEmpoyeeManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogInformation("hello ilogger");
            return View();
        }
        [HttpPost]
     
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