using Microsoft.EntityFrameworkCore;

namespace Packet.Shared
{
    public static class ApplicationDbContextExtensions
    {
        public static IServiceCollection AddCompanyContext(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseInMemoryDatabase("CompanyDb");
            });
            return services;
        }
    }
}
