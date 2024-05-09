using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ReferenceCellCalibrationConfig : IEntityTypeConfiguration<ReferenceCellCalibration>
    {
        public void Configure(EntityTypeBuilder<ReferenceCellCalibration> entity)
        {
            entity.HasKey(e => new { e.Weight });
            entity.Property(e => e.LowMeasuredPosition).HasPrecision(30,10); 
            entity.Property(e => e.LowCurrent).HasPrecision(30,10); 
            entity.Property(e => e.HighMeasuredPosition).HasPrecision(30,10); 
            entity.Property(e => e.HighCurrent).HasPrecision(30,10); 
            entity.HasOne<ReferenceStandard>(e => e.ReferenceStandard).WithMany(ad => ad.ReferenceCellCalibrations).HasForeignKey(e => new {e.RefStandardManufacturer,e.RefStandardModelName,e.RefStandardSerialNo});
        }
    }
}