using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductPictureConfig : IEntityTypeConfiguration<ProductPicture>
    {
        public void Configure(EntityTypeBuilder<ProductPicture> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.Timestamp });
            entity.Property(e => e.UserName).HasMaxLength(32); 
            entity.Property(e => e.Stage).HasMaxLength(32); 
            entity.Property(e => e.FileName).HasMaxLength(64); 
            entity.Property(e => e.LocalPathName).HasMaxLength(128); 
            entity.Property(e => e.BasePath).HasMaxLength(128); 
            entity.Property(e => e.Description).HasMaxLength(160); 
        }
    }
}