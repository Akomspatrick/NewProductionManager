using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class DefectTypeConfig : IEntityTypeConfiguration<DefectType>
    {
        public void Configure(EntityTypeBuilder<DefectType> entity)
        {
            entity.HasKey(e => new { e.DefectName,e.Stage });
            entity.Property(e => e.DefectName).HasMaxLength(32); 
            entity.Property(e => e.Stage).HasMaxLength(32); 
            entity.Property(e => e.DefectDescription).HasMaxLength(160); 
            entity.Property(e => e.TriggerPercentage).HasPrecision(18,6); 
            entity.HasOne<ProductStage>(e => e.ProductStage).WithMany(ad => ad.DefectTypes).HasForeignKey(e => new {e.Stage});
        }
    }
}