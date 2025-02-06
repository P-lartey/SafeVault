using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] UserLogin model)
    {
        // Logic to validate user credentials and generate JWT token
        var token = GenerateJwtToken(model.Username);
        return Ok(new { token });
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("admin-dashboard")]
    public IActionResult AdminDashboard()
    {
        return Ok("Welcome, Admin");
    }

    private string GenerateJwtToken(string username)
    {
        // Logic to generate JWT token
        return "Generated-JWT-Token";
    }
}
