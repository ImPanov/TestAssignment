using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Packet.Shared;

namespace TestAssignment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<Order>>> Company(int id)
        {
            if (_context.Orders == null)
            {
                return NotFound();
            }
            var order = await _context.Orders.Where(e => e.CompanyId == id).ToListAsync();
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }
    }
}
