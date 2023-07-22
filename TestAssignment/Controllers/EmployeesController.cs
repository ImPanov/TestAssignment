using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Packet.Shared;

namespace TestAssignment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<Employee>>> Company(int id)
        {
          if (_context.Employees == null)
          {
              return NotFound();
          }
          var employee = await _context.Employees.Where(e=>e.CompanyId==id).ToListAsync();
            return employee;
        }
    }
}
