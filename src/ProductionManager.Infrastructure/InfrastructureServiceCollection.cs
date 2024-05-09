
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Utils;
using ProductionManager.Infrastructure.Logging;
using ProductionManager.Infrastructure.Persistence;
using ProductionManager.Infrastructure.Persistence.Repositories;
using ProductionManager.Infrastructure.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.Infrastructure
{
    public static class InfrastructureServiceCollection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var applicationAssembly = typeof(InfrastructureServiceCollection).Assembly;
            var constr = GetConnectionstringName.GetConnectionStrName(Environment.MachineName);
            // services.AddDbContext<DocumentVersionManagerContext>(option => option.UseMySQL(configuration.GetConnectionString(Domain.Constants.FixedValues.DBConnectionStringName)!));
            services.AddDbContext<ProductionManagerContext>(option => option.UseMySql(configuration.GetConnectionString(constr)!, GeneralUtils.GetMySqlVersion()));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
