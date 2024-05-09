using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductInitialUnitConfig : IEntityTypeConfiguration<ProductInitialUnit>
    {
        public void Configure(EntityTypeBuilder<ProductInitialUnit> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.TimeStamp });
            entity.Property(e => e.InputUnits).HasMaxLength(32); 
            entity.Property(e => e.OutputUnits).HasMaxLength(32); 
            entity.HasOne<Product>(e => e.Product).WithMany(ad => ad.ProductInitialUnits).HasForeignKey(e => new {e.ProductId});
        }
    }
}