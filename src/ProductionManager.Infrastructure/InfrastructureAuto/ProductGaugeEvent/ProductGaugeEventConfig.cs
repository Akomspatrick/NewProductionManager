using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductGaugeEventConfig : IEntityTypeConfiguration<ProductGaugeEvent>
    {
        public void Configure(EntityTypeBuilder<ProductGaugeEvent> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.TimeStamp });
            entity.Property(e => e.GuageModel).HasMaxLength(32); 
            entity.Property(e => e.GuageLotNo).HasMaxLength(32); 
            entity.Property(e => e.UserName).HasMaxLength(32); 
        }
    }
}