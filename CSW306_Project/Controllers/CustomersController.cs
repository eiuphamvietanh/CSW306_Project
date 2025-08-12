
using CSW306_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSW306_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
     private readonly DbContextProject _context;

        public CustomersController(DbContextProject context)  
        {
            _context = context;
        }
        
        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerID == id);
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customers>>> GetStations()
        {
            return await _context.Customers.ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Customers>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
        
            if (customer == null)
            {
                return NotFound();
            }
        
            return customer;
        }
        
        [HttpPost]
        public async Task<ActionResult<Customers>> CreateCustomer(Customers customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        
            return CreatedAtAction(nameof(GetCustomer), new { id = customer.CustomerID }, customer);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> CustomerStation(int id, Customers customer)
        {
            if (id != customer.CustomerID)
            {
                return BadRequest();
            }
        
            _context.Entry(customer).State = EntityState.Modified;
        
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
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
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
        
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        
            return Ok("Deleted Successfully");
        }
    }
}
