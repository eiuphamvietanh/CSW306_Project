using CSW306_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using CSW306_Project.Data;

namespace CSW306_Project.Controllers
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
        
    }
}
