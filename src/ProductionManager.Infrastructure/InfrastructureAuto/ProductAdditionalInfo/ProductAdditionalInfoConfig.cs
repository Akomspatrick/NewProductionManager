using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductAdditionalInfoConfig : IEntityTypeConfiguration<ProductAdditionalInfo>
    {
        public void Configure(EntityTypeBuilder<ProductAdditionalInfo> entity)
        {
            entity.HasKey(e => new { e.ProductId });
            entity.Property(e => e.InputVoltage).HasPrecision(18,6); 
            entity.Property(e => e.CableLenght).HasPrecision(18,6); 
            entity.Property(e => e.CableLenghtUnit).HasMaxLength(32); 
        }
    }
}