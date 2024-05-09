using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductStageConfig : IEntityTypeConfiguration<ProductStage>
    {
        public void Configure(EntityTypeBuilder<ProductStage> entity)
        {
            entity.HasKey(e => new { e.Stage });
            entity.Property(e => e.Stage).HasMaxLength(32); 
            entity.Property(e => e.StageDescription).HasMaxLength(160); 
            entity.Property(e => e.StageBarcode).HasMaxLength(64); 
            entity.Property(e => e.SaveBarCode).HasMaxLength(32); 
            entity.Property(e => e.SaveAndEndBarCode).HasMaxLength(32); 
        }
    }
}