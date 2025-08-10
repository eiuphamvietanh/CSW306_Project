using CSW306_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Collections.Specialized.BitVector32;
using CSW306_Project.Data;


namespace CSW306_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        private readonly DbContextProject _context;

        public StationsController(DbContextProject context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stations>>> GetStations()
        {
            return await _context.Stations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Stations>> GetStation(int id)
        {
            var station = await _context.Stations.FindAsync(id);

            if (station == null)
            {
                return NotFound();
            }

            return station;
        }


        [HttpPost]
        public async Task<ActionResult<Stations>> CreateStation(Stations station)
        {
            _context.Stations.Add(station);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStation), new { id = station.StationID }, station);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStation(int id, Stations station)
        {
            if (id != station.StationID)
            {
                return BadRequest();
            }

            _context.Entry(station).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

     
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStation(int id)
        {
            var station = await _context.Stations.FindAsync(id);
            if (station == null)
            {
                return NotFound();
            }

            _context.Stations.Remove(station);
            await _context.SaveChangesAsync();

            return Ok("Deleted Successfully");
        }

        private bool StationExists(int id)
        {
            return _context.Stations.Any(e => e.StationID == id);
        }

    }
}
