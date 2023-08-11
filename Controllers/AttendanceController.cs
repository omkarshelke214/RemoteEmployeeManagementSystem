using Microsoft.AspNetCore.Mvc;
using RemoteEmpoyeeManagementSystem.Models;

namespace RemoteEmpoyeeManagementSystem.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly IEmpAttendaceRepository _empAttendanceRepository;
        private readonly ILogger _logger;
        public AttendanceController(IEmpAttendaceRepository empAttendaceRepository, ILogger<AttendanceController> logger)
        {
            _empAttendanceRepository = empAttendaceRepository;
            _logger = logger;
        }
        public IActionResult Index()
        {
           var attendaces= _empAttendanceRepository.GetEmpAttendace();
            _logger.LogInformation("index attendacne controller");
            return View(attendaces);
        }
        [HttpPost]
        public IActionResult MarkAttedance()
        {
           
            var empatt= _empAttendanceRepository.MarkEmpAtendace(1);
            return View("Index",empatt);
        }
    }
}
