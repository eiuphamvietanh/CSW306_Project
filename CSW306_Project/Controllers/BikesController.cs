
using CSW306_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Collections.Specialized.BitVector32;

namespace CSW306_Project.Controllerss
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : ControllerBase
    {
        private readonly DbContextProject _context;

        public BikesController(DbContextProject context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bikes>>> GetBikes()
        {
            return await _context.Bikes.ToListAsync();
        }



    }
}
