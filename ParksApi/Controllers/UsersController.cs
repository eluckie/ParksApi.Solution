using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksApi.Models;

namespace ParksApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UsersController : ControllerBase
  {
    [Authorize]
    [HttpGet("Admins")]
    [Authorize(Roles = "admin")]
    public IActionResult Admins()
    {
      var currentUser = GetCurrentUser();
      return Ok($"Hi {currentUser.Name}, you are an {currentUser.Role}");
    }

    [Authorize]
    [HttpGet("Users")]
    [Authorize(Roles = "user, admin")]
    public IActionResult Users()
    {
      var currentUser = GetCurrentUser();
      return Ok($"Hi {currentUser.Name}");
    }

    private User GetCurrentUser()
    {
      var identity = HttpContext.User.Identity as ClaimsIdentity;

      if (identity != null)
      {
        var userClaims = identity.Claims;

        return new User
        {
          Username = userClaims.FirstOrDefault(e => e.Type == ClaimTypes.NameIdentifier)?.Value,
          Email = userClaims.FirstOrDefault(e => e.Type == ClaimTypes.Email)?.Value,
          Name = userClaims.FirstOrDefault(e => e.Type == ClaimTypes.GivenName)?.Value,
          Role = userClaims.FirstOrDefault(e => e.Type == ClaimTypes.Role)?.Value
        };
      }

      return null;
    }
  }
}