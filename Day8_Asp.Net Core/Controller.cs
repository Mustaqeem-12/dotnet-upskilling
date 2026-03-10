using Microsoft.AspNetCore.Mvc;

namespace _2ndweekasp.net.Controllers
{
    public class PracticeController : Controller
    {
        public IActionResult Index()
        {
            return Content("hello this is my second week tasks");
        }
    }
}


@{
    ViewData["Title"] = "Home Page";
}

<div class="text-center">
    <h1>Hey I'm Mustaqeem</h1>
    <h2>Creted using MVC </h2>
    <br />
    <p>this project has created for learning asp.net core mvc and also i want to learn about mvc flows and structures</p>

</div>
