using EmployeeManagement.Models;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeApiController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeApiController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }
        [HttpGet("{empId}")]
        public async Task<IActionResult> GetById(string empId)
        {
            var emp = await _service.GetByIdAsync(empId);
            if (emp == null) return NotFound();
            return Ok(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee emp)
        {
            var created = await _service.AddAsync(emp);
            return Ok(created);
        }

        [HttpPut("{empId}")]
        public async Task<IActionResult> Update(string empId,Employee emp)
        {
            if (empId != emp.EmpId) return BadRequest();

            var updated = await _service.UpdateAsync(emp);
            if (updated == null ) return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{empId}")]
        public async Task<IActionResult> Delete(string empId)
        {
            var result = await _service.DeleteAsync(empId);
            if (!result) return NotFound();
            return Ok("Successfully Deleted");
        }
    }
}
