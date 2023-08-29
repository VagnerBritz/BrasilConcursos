using BrasilConcursos.Application.Interfaces;
using BrasilConcursos.Application.Mappings;
using BrasilConcursos.Application.Services;
using BrasilConcursos.Domain.Interfaces;
using BrasilConcursos.Infra.Data.Context;
using BrasilConcursos.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BrasilConcursos.Infra.IoC
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                options.EnableSensitiveDataLogging();
                options.LogTo(Console.WriteLine);
            });
            services.AddScoped<IConcourseRepository, ConcourseRepository>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IConcourseService, ConcourseService>();
            services.AddAutoMapper(typeof(DomainToDtoProfile));

            return services;
        }

    }
}
