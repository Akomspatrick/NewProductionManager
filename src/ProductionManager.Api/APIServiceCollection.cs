using Asp.Versioning;
using Microsoft.EntityFrameworkCore;
using ProductionManager.Infrastructure.Persistence;

namespace ProductionManager.Api;

public static class APIServiceCollection
{
    public static IServiceCollection AddAPIServices(this IServiceCollection services, IConfiguration configuration)
    {
        //var applicationAssembly = typeof(APIServiceCollection).Assembly;
        services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<Program>());
        //  services.AddDbContext<ProductionManagerContext>(option => option.UseMySQL(configuration.GetConnectionString(ProductionManager.Domain.Constants.FixedValues.DBConnectionStringName)!));
        services.AddCors();
        services.AddApiVersioning(
            option =>
            {
                option.ReportApiVersions = true;
                option.AssumeDefaultVersionWhenUnspecified = true;
                option.DefaultApiVersion = new ApiVersion(2, 0);
                option.ApiVersionReader = ApiVersionReader.Combine(
                    new QueryStringApiVersionReader("api-version"),
                    new HeaderApiVersionReader("api-version"),
                    new MediaTypeApiVersionReader("version")
                    );


            });

        // services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<Program>());
        return services;
    }
}
