using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductFinalUnitConfig : IEntityTypeConfiguration<ProductFinalUnit>
    {
        public void Configure(EntityTypeBuilder<ProductFinalUnit> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.TimeStamp });
            entity.Property(e => e.InputUnit).HasMaxLength(32); 
            entity.Property(e => e.OuputUnits).HasMaxLength(32); 
            entity.Property(e => e.IndicatorType).HasMaxLength(32); 
            entity.Property(e => e.IndicatorSerialNo).HasMaxLength(32); 
            entity.Property(e => e.PinSize).HasPrecision(18,6); 
            entity.Property(e => e.LowWeight).HasPrecision(10,0); 
            entity.Property(e => e.HighWeight).HasPrecision(10,0); 
            entity.HasOne<Product>(e => e.Product).WithMany(ad => ad.ProductFinalUnits).HasForeignKey(e => new {e.ProductId});
        }
    }
}