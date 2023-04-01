using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ParksApi.Models;

namespace ParksApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class LoginController : ControllerBase
  {
    private IConfiguration _config;

    public LoginController(IConfiguration config)
    {
      _config = config;
    }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult Login(UserLogin userLogin)
    {
      User user = Authenticate(userLogin);

      if (user != null)
      {
        var token = Generate(user);
        return Ok(token);
      }

      return NotFound("User not found");
    }

    private string Generate(User user)
    {
      var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
      var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

      var claims = new[]
      {
        new Claim(ClaimTypes.NameIdentifier, user.Username),
        new Claim(ClaimTypes.Email, user.Email),
        new Claim(ClaimTypes.GivenName, user.Name),
        new Claim(ClaimTypes.Role, user.Role)
      };

      var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"],
      claims,
      expires: DateTime.Now.AddMinutes(15),
      signingCredentials: credentials);

      return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private User Authenticate(UserLogin userLogin)
    {
      User currentUser = UserConstants.Users.FirstOrDefault(e => e.Username.ToLower() == userLogin.Username.ToLower() && e.Password == userLogin.Password);

      if (currentUser != null)
      {
        return currentUser;
      }

      return null;
    }
  }
}