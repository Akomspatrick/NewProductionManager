using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class TestConfig : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> entity)
        {
            entity.HasKey(e => new { e.Timestamp,e.ProductId,e.RefStandardSerialNo,e.RefStandardManufacturer,e.RefStandardModelName });
            entity.Property(e => e.UserName).HasMaxLength(32); 
            entity.Property(e => e.RefStandardSerialNo).HasMaxLength(32); 
            entity.Property(e => e.RefStandardManufacturer).HasMaxLength(32); 
            entity.Property(e => e.RefStandardModelName).HasMaxLength(32); 
            entity.Property(e => e.ExcitationResistance).HasPrecision(18,6); 
            entity.Property(e => e.SignalResistance).HasPrecision(18,6); 
            entity.HasOne<ReferenceStandard>(e => e.ReferenceStandard).WithMany(ad => ad.Tests).HasForeignKey(e => new {e.RefStandardSerialNo,e.RefStandardManufacturer,e.RefStandardModelName});
        }
    }
}