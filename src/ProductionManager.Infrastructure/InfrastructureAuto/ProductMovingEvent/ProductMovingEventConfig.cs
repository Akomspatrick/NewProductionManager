using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductMovingEventConfig : IEntityTypeConfiguration<ProductMovingEvent>
    {
        public void Configure(EntityTypeBuilder<ProductMovingEvent> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.TimeStamp });
            entity.Property(e => e.SourceStage).HasMaxLength(32); 
            entity.Property(e => e.DestinationStage).HasMaxLength(32); 
            entity.Property(e => e.MovingNotes).HasMaxLength(256); 
            entity.Property(e => e.UserName).HasMaxLength(32); 
        }
    }
}