using Microsoft.AspNetCore.Mvc;
using JewelleryApp.Data;
using JewelleryApp.Models;
using System.Linq;

namespace JewelleryApp.Controllers
{
    public class JewelleryController : Controller
    {
        private readonly JewelleryDbContext _context;
        public JewelleryController(JewelleryDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.jewels.ToList();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(jewel j)
        {
            _context.jewels.Add(j);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
