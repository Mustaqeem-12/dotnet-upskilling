using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel user)
        {
            if (user == null || user.Username == null || user.Password == null)
            {
                return BadRequest("Invalid input");
            }

            if (user.Username != "Employee" || user.Password != "Emp1234")
            {
                return Unauthorized("Invalid credentials");
            }

            var keyString = "THIS_IS_A_VERY_LONG_SECRET_KEY_FOR_SECURITY_123456789";
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyString));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
        new Claim(ClaimTypes.Name, user.Username)
    };

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            var handler = new JwtSecurityTokenHandler();
            var jwt = handler.WriteToken(token);

            return Ok(new { token = jwt });
        }
    }

    public class LoginModel
    {
        public  string Username { get; set; }
        public  string Password { get; set; }
    }
}
