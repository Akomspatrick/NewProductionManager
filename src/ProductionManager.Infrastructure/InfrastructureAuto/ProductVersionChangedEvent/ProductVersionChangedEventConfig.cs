using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductVersionChangedEventConfig : IEntityTypeConfiguration<ProductVersionChangedEvent>
    {
        public void Configure(EntityTypeBuilder<ProductVersionChangedEvent> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.TimeStamp });
            entity.Property(e => e.PrevModelName).HasMaxLength(32); 
            entity.Property(e => e.CurrentPrevModelName).HasMaxLength(32); 
            entity.Property(e => e.UserName).HasMaxLength(32); 
        }
    }
}