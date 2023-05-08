using KForce.Service.Data;
using KForce.Service.Model;
using KForce.Service.Repositories;
using KForce.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace KForce.Service.API;

public static class ServiceExtensions
{
    public static void ConfigureDatabase(this IServiceCollection services)
    {
        services.AddDbContext<KForceDbContext>(options =>
            options.UseSqlServer(@"server=PE-IT001610\SQLEXPRESS; 
                                    database = KForce; 
                                    Trusted_Connection = true;
                                    TrustServerCertificate=True;
                                    MultipleActiveResultSets=True"
                                ));
    }
    public static void ConfigureSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1.0",
                Title = "Car Service",
                Description = "API with multiple operations",
                Contact = new OpenApiContact
                {
                    Name = "Jose Coronel"
                },
            });
        });
    }

    public static void ConfigureEmbeddedServices(this IServiceCollection services)
    {
        services.AddCors();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
    }

    public static void ConfigureCustomServices(this IServiceCollection services)
    {
        services.AddScoped<IGenericService<Car>, GenericService<Car>>();
        services.AddScoped<IGenericRepository<Car>, GenericRepository<Car>>();

    }
}