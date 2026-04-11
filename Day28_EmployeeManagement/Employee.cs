using EmployeeManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EmployeeManagement.Models
{

public class Employee
{
    [Key]
    public string EmpId { get; set; } = string.Empty;

    [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
    public string Email { get; set; } = string.Empty;

        [Range(1000, 1000000, ErrorMessage ="Salary Must be Valid")]
    public decimal Salary { get; set; }

        [Required(ErrorMessage = "Department is required")]
    public int DepartmentId { get; set; }

    [JsonIgnore]
    public Department? Department { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

}
