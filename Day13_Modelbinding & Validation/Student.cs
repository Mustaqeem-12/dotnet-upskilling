using System.ComponentModel.DataAnnotations;

namespace _2ndweekasp.net.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name Must be Filled")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 80, ErrorMessage = "Age Must be Between 18 to 80")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email must be a valid email address")]
        public string Email { get; set; }
    }
}
