using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class MassLoadApplicationConfig : IEntityTypeConfiguration<MassLoadApplication>
    {
        public void Configure(EntityTypeBuilder<MassLoadApplication> entity)
        {
        }
    }
}