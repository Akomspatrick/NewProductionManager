using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductShippingEventConfig : IEntityTypeConfiguration<ProductShippingEvent>
    {
        public void Configure(EntityTypeBuilder<ProductShippingEvent> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.TimeStamp });
            entity.Property(e => e.UserName).HasMaxLength(32); 
        }
    }
}