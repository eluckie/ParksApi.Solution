using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksApi.Models;

namespace ParksApi.Controllers
{
  [Authorize]
  [ApiController]
  [Route("api/[controller]")]
  public class ParksController : ControllerBase
  {
    private readonly ParksApiContext _db;

    public ParksController(ParksApiContext db)
    {
      _db = db;
    }

    // GET api/Parks?page=1&pageSize=10
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> Get(string city, string state, bool statePark, bool nationalPark, int page = 1, int pageSize = 10)
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

      if (statePark)
      {
        query = query.Where(e => e.StatePark == true);
      }

      if (nationalPark)
      {
        query = query.Where(e => e.NationalPark == true);
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
        QueriedParks = parks,
        TotalParks = totalCount,
        CurrentPage = page,
        ParksPerPage = pageSize
      };
      // end pagination

      return Ok(response);
    }

    // GET api/Parks/{id}
    [AllowAnonymous]
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

    // POST api/Parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    // PUT api/Parks/{id}
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

      return Ok();
    }

    // DELETE api/Parks/{id}
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

    // PATCH api/Parks/{id}
    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, JsonPatchDocument parkModel)
    {
      Park park = await _db.Parks.FindAsync(id);

      if (!ParkExists(id))
      {
        return NotFound();
      }

      parkModel.ApplyTo(park);
      await _db.SaveChangesAsync();
      return Ok();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(entry => entry.ParkId == id);
    }
  }
}