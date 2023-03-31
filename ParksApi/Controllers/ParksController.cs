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
    public async Task<IActionResult> Get(string city, string state, int page = 1, int pageSize = 10)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (city != null)
      {
        query = query.Where(e => e.City == city);
      }

      if (state != null)
      {
        query = query.Where(e => e.State == state);
      }

      // add pagination
      int skip = (page - 1) * pageSize;

      List<Park> parks = await query
        .Skip(skip)
        .Take(pageSize)
        .ToListAsync();

      int totalCount = _db.Parks.Count();
      var response = new
      {
        Parks = parks,
        TotalParks = totalCount,
        CurrentPage = page,
        ParksPerPage = pageSize
      };

      return Ok(response);
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

    // PUT parks/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Parks.Update(park);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return Accepted();
    }

    // DELETE parks/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(entry => entry.ParkId == id);
    }
  }
}