using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1API.Contexts;
using F1API.Models;

namespace F1API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RaceController : ControllerBase
{
    private readonly F1Context context;

    public RaceController(F1Context _context)
    {
        this.context = _context;
    }

    [HttpGet] // axios.get("http://localhost:5034/api/races/");
    public async Task<ActionResult<List< Race >>> GetRaces()
    {
         try
        {
            List<Race> races = await context.Races.ToListAsync();

            if (races != null)
            {
                return Ok(races);
            }
            else
            {
                return NotFound();
            }
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpGet("{Id}")] // axios.get("http://localhost:5034/api/race/{Id}");
    public async Task<ActionResult< Driver >> GetRaceById(int Id)
    {
        try
        {
            Race? race = await context.Races.FindAsync(Id);

            if (race != null)
            {
                return Ok(race);
            }
            else
            {
                return NotFound(Id);
            }
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpPost] // axios.post("http://localhost:5034/api/races/");
    public async Task<ActionResult< Race >> Post(Race newRace)
    {
        try
        {
            context.Races.Add(newRace);
            await context.SaveChangesAsync();

            return Ok(newRace);
        }
        catch
        {
            return StatusCode(500);
        }        
    }

    [HttpPut] // axios.put("http://localhost:5034/api/races");
    public async Task< IActionResult > Put(Race updatedRace)
    {
        try
        {
            context.Entry(updatedRace).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return Ok();
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpDelete("{Id}")] // axios.delete("http://localhost:5034/api/race/{Id}");
    public async Task< ActionResult > DeleteById(int id)
    {
        try
        {
            Race? race = await context.Races.FindAsync(id);

            if (race != null)
            {
                context.Races.Remove(race);
                await context.SaveChangesAsync();

                return Ok();;   
            }
            else
            {
                return NotFound(id);
            }
        }
        catch
        {
            return StatusCode(500);
        }
    }
}