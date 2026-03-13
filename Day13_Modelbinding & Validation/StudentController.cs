using Microsoft.AspNetCore.Mvc;
using _2ndweekasp.net.Models;

namespace _2ndweekasp.net.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Student has Registered Successfully";
            }

            return View(student);
        }
    }
}
