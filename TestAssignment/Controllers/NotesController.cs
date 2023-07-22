using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Packet.Shared;

namespace TestAssignment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NotesController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<Note>>> Company(int id)
        {
            if (_context.Notes == null)
            {
                return NotFound();
            }
            var note = await _context.Notes.Where(e => e.CompanyId == id).ToListAsync();
            if (note == null)
            {
                return NotFound();
            }
            return note;
        }
    }
}
