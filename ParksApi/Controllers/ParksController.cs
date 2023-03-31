using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksApi.Models;

namespace ParksApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ParksController : ControllerBase
  {
    private readonly ParksApiContext _db;

    public ParksController(ParksApiContext db)
    {
      _db = db;
    }

    // GET /parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      return await _db.Parks.ToListAsync();
    }

    // GET /parks/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    // POST /parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }
  }
}