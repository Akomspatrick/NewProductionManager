using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ReferenceStandardConfig : IEntityTypeConfiguration<ReferenceStandard>
    {
        public void Configure(EntityTypeBuilder<ReferenceStandard> entity)
        {
            entity.HasKey(e => new { e.RefStandardManufacturer,e.RefStandardModelName,e.RefStandardSerialNo });
            entity.Property(e => e.RefStandardManufacturer).HasMaxLength(32); 
            entity.Property(e => e.RefStandardModelName).HasMaxLength(32); 
            entity.Property(e => e.RefStandardSerialNo).HasMaxLength(32); 
            entity.Property(e => e.B0).HasPrecision(18,6); 
            entity.Property(e => e.B1).HasPrecision(18,6); 
            entity.Property(e => e.B2).HasPrecision(18,6); 
            entity.Property(e => e.B3).HasPrecision(18,6); 
            entity.Property(e => e.B4).HasPrecision(18,6); 
        }
    }
}