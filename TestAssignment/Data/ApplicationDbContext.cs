using Microsoft.EntityFrameworkCore;
using Packet.Shared;

namespace Packet.Shared
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("CompanyDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
