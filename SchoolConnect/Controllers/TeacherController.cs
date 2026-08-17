using Microsoft.AspNetCore.Mvc;

namespace SchoolConnect.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Messages()
        {
            return View();
        }

        public IActionResult Classes()
        {
            return View();
        }

        public IActionResult Marks()
        {
            return View();
        }

        public IActionResult Announcements()
        {
            return View();
        }

        public IActionResult AIAssistant()
        {
            return View();
        }
    }
}