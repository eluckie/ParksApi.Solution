using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ParksApi.Models;

namespace ParksApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UsersController : ControllerBase
  {
    private readonly ParksApiContext _db;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    // public UsersController(UserManager<User> userManager, SignInManager<User> signInManager, ParksApiContext db)
    // {
    //   _userManager = userManager;
    //   _signInManager = signInManager;
    //   _db = db;
    // }

    // [AllowAnonymous]
    // [HttpPost]
    // public async Task<IActionResult> Register(User model)
    // {
    //   User user = new User { Email = model.Email, Username = model.Username, Name = model.Name };
    //   IdentityResult result = await _userManager.CreateAsync(user, model.Password);
    //   if (result.Succeeded)
    //   {
    //     return Ok(user);
    //   }
    //   else
    //   {
    //     return BadRequest(model);
    //   }
    // }
  }
}

    // [Authorize]
    // [HttpGet("Admins")]
    // [Authorize(Roles = "admin")]
    // public IActionResult Admins()
    // {
    //   var currentUser = GetCurrentUser();
    //   return Ok($"Hi {currentUser.Name}");
    // }

    // [Authorize]
    // [HttpGet("Users")]
    // [Authorize(Roles = "user, admin")]
    // public IActionResult Users()
    // {
    //   var currentUser = GetCurrentUser();
    //   return Ok($"Hi {currentUser.Name}");
    // }

    // private User GetCurrentUser()
    // {
    //   var identity = HttpContext.User.Identity as ClaimsIdentity;

    //   if (identity != null)
    //   {
    //     var userClaims = identity.Claims;

    //     return new User
    //     {
    //       Username = userClaims.FirstOrDefault(e => e.Type == ClaimTypes.NameIdentifier)?.Value,
    //       Email = userClaims.FirstOrDefault(e => e.Type == ClaimTypes.Email)?.Value,
    //       Name = userClaims.FirstOrDefault(e => e.Type == ClaimTypes.GivenName)?.Value,
    //     };
    //   }

    //   return null;
    // }