using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmployeeManagement.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employees.Include(e => e.Department).ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(string empId)
        {
            return await _context.Employees.FindAsync(empId);
        }

        public async Task<Employee> AddAsync(Employee employee)
        {
            // Generate Employee ID
            var lastEmp = await _context.Employees
                .OrderByDescending(e => e.EmpId)
                .FirstOrDefaultAsync();

            if (lastEmp == null)
                employee.EmpId = "Emp0001";
            else
            {
                // Increment last ID number
                var lastIdNumber = int.Parse(lastEmp.EmpId.Substring(3));
                employee.EmpId = "Emp" + (lastIdNumber + 1).ToString("D4");
            }

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee?> UpdateAsync(Employee employee)
        {
            var existing = await _context.Employees.FindAsync(employee.EmpId);
            if (existing == null) return null;

            existing.Name = employee.Name;
            existing.Email = employee.Email;
            existing.Salary = employee.Salary;
            existing.DepartmentId = employee.DepartmentId;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(string empId)
        {
            var existing = await _context.Employees.FindAsync(empId);
            if (existing == null) return false;

            _context.Employees.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
