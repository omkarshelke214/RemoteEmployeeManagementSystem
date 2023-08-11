using Microsoft.AspNetCore.Mvc;
using RemoteEmpoyeeManagementSystem.Models;

namespace RemoteEmpoyeeManagementSystem.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly IEmpAttendaceRepository _empAttendanceRepository;
        public AttendanceController(IEmpAttendaceRepository empAttendaceRepository)
        {
            _empAttendanceRepository = empAttendaceRepository;
        }
        public IActionResult Index()
        {
           var attendaces= _empAttendanceRepository.GetEmpAttendace();
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
