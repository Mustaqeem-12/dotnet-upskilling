using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration; 
namespace _2ndweekasp.net.Controllers { 
  public class StudentController : Controller { 
    private readonly ILogger<StudentController> _logger;
    public StudentController(ILogger<StudentController> logger) { 
      _logger = logger; 
    } public IActionResult Info() { 
      _logger.LogInformation("User Logged in"); 
      return View(); 
    } 
  }
}
