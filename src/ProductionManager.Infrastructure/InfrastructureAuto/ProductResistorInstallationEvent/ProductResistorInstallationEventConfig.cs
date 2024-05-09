using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductResistorInstallationEventConfig : IEntityTypeConfiguration<ProductResistorInstallationEvent>
    {
        public void Configure(EntityTypeBuilder<ProductResistorInstallationEvent> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.TimeStamp });
            entity.Property(e => e.UserName).HasMaxLength(32); 
        }
    }
}