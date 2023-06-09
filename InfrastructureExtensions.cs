using Microsoft.EntityFrameworkCore;
using Cinema.Infrastructure;

namespace Cinema;

public static class InfrastructureExtensions
{
    public static IServiceCollection RegisterDataBase(this IServiceCollection services)
    {
        var dbConnectionString = "User ID=postgres; Password=admin; Host=localhost; Port=5432; Database=FilmDb;";
        services.AddDbContext<AppDbContext>((serviceProvider, options) =>
        {
            var currentAssemblyName = typeof(AppDbContext).Assembly.FullName;
            options.UseNpgsql(
                dbConnectionString,
               npgsqlOptionsAction:b:NpgsqlDbContextOptionsBuilder => b.MigrationsAssembly(currentAssemblyName)) ;
        });

        return services;
    }
}