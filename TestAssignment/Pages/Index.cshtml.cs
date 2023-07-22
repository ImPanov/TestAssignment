using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Packet.Shared;

namespace TestAssignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext db;

        public IEnumerable<Company> Companies { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext injectContext)
        {
            _logger = logger;
            db = injectContext;
        }

        public async Task OnGet()
        {
            Companies = await db.Companies.ToListAsync();
        }
    }
}