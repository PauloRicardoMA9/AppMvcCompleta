using ma9.App.Data;
using ma9.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ma9.App.Configurations
{
    public static class ContextConfig
    {
        public static IServiceCollection AddContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MeuDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MeuDbContext")));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext")));

            return services;
        }
    }
}
