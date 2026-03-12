using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace _2ndweekasp.net.Controllers
{
    public class StudentController : Controller
    {
        private readonly IConfiguration _config;
        public StudentController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Info()
        {
            string appName = _config["AppSettings:AppName"];
            ViewBag.Name = appName;         

            return View();
        }
    }
}
