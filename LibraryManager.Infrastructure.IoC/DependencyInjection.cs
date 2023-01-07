using AutoMapper;
using LibraryManager.Application.Interfaces.Services;
using LibraryManager.Application.Mappers;
using LibraryManager.Application.Services;
using LibraryManager.Domain.Interfaces.Repositories;
using LibraryManager.Domain.Models;
using LibraryManager.Infrastructure.Context;
using LibraryManager.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
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
            
            return services;
        }

        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole<int>>()
                    .AddEntityFrameworkStores<LibraryContext>()
                    .AddDefaultTokenProviders();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPublisherRepository, PublisherRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();

            return services;
        }

        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(PublisherProfile));

            return services;
        }
    }
}