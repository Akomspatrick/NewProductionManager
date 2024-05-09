using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductGaugeInspectionEventConfig : IEntityTypeConfiguration<ProductGaugeInspectionEvent>
    {
        public void Configure(EntityTypeBuilder<ProductGaugeInspectionEvent> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.TimeStamp });
            entity.Property(e => e.DefectName).HasMaxLength(32); 
            entity.Property(e => e.UserName).HasMaxLength(32); 
        }
    }
}