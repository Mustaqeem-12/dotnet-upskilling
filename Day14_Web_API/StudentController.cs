using Microsoft.AspNetCore.Mvc;
using Day14WebAPI.Models;

namespace Day14WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Mustaqeem", Course = ".NET" },
            new Student { Id = 3, Name = "Ali", Course = "Java" }
        };

        
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);
            return Ok(student);
        }
    }
}
