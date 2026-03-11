using Microsoft.AspNetCore.Mvc;

namespace _2ndweekasp.net.Services
{
    public class StudentController : Controller
    {
        public readonly StudentService _service;

            public StudentController(StudentService service)
        {
            _service = service;
        }
        public IActionResult Info1()
        {
            ViewBag.Message = _service.GetMessage();
            return  View();
        }
    }
}
