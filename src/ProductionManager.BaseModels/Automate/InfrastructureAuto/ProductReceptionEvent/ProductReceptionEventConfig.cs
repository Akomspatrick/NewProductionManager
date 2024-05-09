using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductReceptionEventConfig : IEntityTypeConfiguration<ProductReceptionEvent>
    {
        public void Configure(EntityTypeBuilder<ProductReceptionEvent> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.TimeStamp });
            entity.Property(e => e.Notes).HasMaxLength(256); 
            entity.Property(e => e.UserName).HasMaxLength(32); 
        }
    }
}