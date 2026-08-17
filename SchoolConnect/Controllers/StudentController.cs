using Microsoft.AspNetCore.Mvc;

namespace SchoolConnectPlus.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Announcements()
        {
            return View();
        }

        public IActionResult Classes()
        {
            return View();
        }
    }
}