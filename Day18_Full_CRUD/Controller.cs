using Microsoft.AspNetCore.Mvc;
using LuLuMall.Data;
using LuLuMall.Models;
using System.Linq;

namespace LuLuMall.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShoppingDbContext _context;

            public ProductsController(ShoppingDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Products.ToList();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
