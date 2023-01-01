using LibraryManager.Domain.Interfaces.Repositories;
using LibraryManager.Infrastructure.Context;
using LibraryManager.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManager.Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSqlInfrastructure(this IServiceCollection services, IConfiguration configuration )
        {
            services.AddDbContext<LibraryContext>(opt => opt.UseSqlServer(
                configuration.GetConnectionString("LibraryConnection"),
                b => b.MigrationsAssembly(typeof(LibraryContext).Assembly.FullName)));

            services.AddScoped<IPublisherRepository, PublisherRepository>();

            return services;
        }
    }
}