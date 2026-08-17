using Microsoft.AspNetCore.Mvc;

namespace SchoolConnect.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Announcements()
        {
            return View();
        }

        public IActionResult Finance()
        {
            return View();
        }

        public IActionResult Analytics()
        {
            return View();
        }
        public IActionResult StoreManagement()
        {
            return View();
        }
    }
}
