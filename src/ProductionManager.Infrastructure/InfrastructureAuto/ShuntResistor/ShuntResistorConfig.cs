using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ShuntResistorConfig : IEntityTypeConfiguration<ShuntResistor>
    {
        public void Configure(EntityTypeBuilder<ShuntResistor> entity)
        {
            entity.HasKey(e => new { e.Value });
            entity.Property(e => e.Value).HasPrecision(10,0); 
        }
    }
}