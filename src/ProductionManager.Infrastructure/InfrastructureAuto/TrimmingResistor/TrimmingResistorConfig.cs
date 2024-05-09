using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class TrimmingResistorConfig : IEntityTypeConfiguration<TrimmingResistor>
    {
        public void Configure(EntityTypeBuilder<TrimmingResistor> entity)
        {
            entity.HasKey(e => new { e.Value });
            entity.Property(e => e.Value).HasPrecision(10,0); 
        }
    }
}