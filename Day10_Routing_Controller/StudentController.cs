
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace _2ndweekasp.net.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
