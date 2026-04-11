using EmployeeManagement.Data;
using EmployeeManagement.Models;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        private readonly AppDbContext _context;

        public EmployeeController(IEmployeeService service, AppDbContext context)
        {
            _service = service;
            _context = context;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // GET: Details
        public async Task<IActionResult> Details(string empId)
        {
            var emp = await _service.GetByIdAsync(empId);
            if (emp == null) return NotFound();
            return View(emp);
        }

        // GET: Create
        public IActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(_context.Departments, "Id", "Name");
            return View();
        }

        // POST: Create
        [HttpPost]
        public async Task<IActionResult> Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(emp);
                TempData["SuccessMessage"] = "Employee Created Successfully..!";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.DepartmentId = new SelectList(_context.Departments, "Id", "Name", emp.DepartmentId);
            return View(emp);
        }

        // GET: Edit
        public async Task<IActionResult> Edit(string empId)
        {
            var emp = await _service.GetByIdAsync(empId);
            if (emp == null) return NotFound();

            ViewBag.DepartmentId = new SelectList(_context.Departments, "Id", "Name", emp.DepartmentId);
            return View(emp);
        }

        // POST: Edit
        [HttpPost]
        public async Task<IActionResult> Edit(string empId, Employee emp)
        {
            if (empId != emp.EmpId) return BadRequest();

            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(emp);
                TempData["SuccessMessage"] = "Employee Update Successfully..!";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.DepartmentId = new SelectList(_context.Departments, "Id", "Name", emp.DepartmentId);
            return View(emp);
        }

        // GET: Delete
        public async Task<IActionResult> Delete(string empId)
        {
            var emp = await _service.GetByIdAsync(empId);
            if (emp == null) return NotFound();
            return View(emp);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string empId)
        {
            await _service.DeleteAsync(empId);
            TempData["SuccessMessage"] = "Employee has been Deleted Successfully..!";
            return RedirectToAction(nameof(Index));
        }

    }
}
