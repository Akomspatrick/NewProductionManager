using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductCertificateConfig : IEntityTypeConfiguration<ProductCertificate>
    {
        public void Configure(EntityTypeBuilder<ProductCertificate> entity)
        {
            entity.HasKey(e => new { e.ProductCertificateId,e.ProductId });
            entity.Property(e => e.CertifcateType).HasMaxLength(32); 
            entity.Property(e => e.JsonData).HasMaxLength(2500); 
            entity.HasOne<Product>(e => e.Product).WithMany(ad => ad.ProductCertificates).HasForeignKey(e => new {e.ProductId});
            entity.HasOne<ProductCertificateType>(e => e.ProductCertificateType).WithMany(ad => ad.ProductCertificates).HasForeignKey(e => new {e.CertifcateType});
            
        }
    }
}