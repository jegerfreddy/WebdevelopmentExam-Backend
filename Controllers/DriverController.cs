using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1API.Contexts;
using F1API.Models;

namespace F1API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DriverController : ControllerBase
{
    private readonly F1Context context;

    public DriverController(F1Context _context)
    {
        this.context = _context;
    }

    [HttpGet] // axios.get("http://localhost:5034/api/driver/");
    public async Task<ActionResult< List<Driver> >> GetDrivers()
    {
         try
        {
            List<Driver> drivers = await context.Drivers.ToListAsync();

            if (drivers != null)
            {
                return Ok(drivers);
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

    [HttpGet("{Id}")] // axios.get("http://localhost:5034/api/driver/{Id}");
    public async Task<ActionResult< Driver >> GetDriverById(int Id)
    {
        try
        {
            Driver? driver = await context.Drivers.FindAsync(Id);

            if (driver != null)
            {
                return Ok(driver);
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

    /*

    // This get-method was never used because i use the drivers-array already loaded
    // into the frontend to get drivers by name

    [HttpGet]
    [Route("api/[GetDriverByName]/{Name}")]
    public async Task<ActionResult< Driver >> GetDriverByName(string Name)
    {
        try
        {
            Driver? driver = await context.Drivers.FindAsync(Name);

            if (driver != null)
            {
                return Ok(driver);
            }
            else
            {
                return NotFound(Name);
            }
        }
        catch
        {
            return StatusCode(500);
        }
    }*/

    [HttpPost] // axios.post("http://localhost:5034/api/driver/");
    public async Task<ActionResult< Driver >> Post(Driver newDriver)
    {
        try
        {
            context.Drivers.Add(newDriver);
            await context.SaveChangesAsync();

            return Ok(newDriver);
        }
        catch
        {
            return StatusCode(500);
        }        
    }

    [HttpPut] // axios.put("http://localhost:5034/api/driver");
    public async Task< IActionResult > Put(Driver updatedDriver)
    {
        try
        {
            context.Entry(updatedDriver).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return Ok();
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpDelete("{Id}")] // axios.delete("http://localhost:5034/api/driver/{Id}");
    public async Task< ActionResult > DeleteById(int id)
    {
        try
        {
            Driver? driver = await context.Drivers.FindAsync(id);

            if (driver != null)
            {
                context.Drivers.Remove(driver);
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