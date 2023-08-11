using Microsoft.AspNetCore.Mvc;
using RemoteEmpoyeeManagementSystem.Models;

namespace RemoteEmpoyeeManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserLogin credentials)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
               return View(); 
            }
            
        }
    }
}
