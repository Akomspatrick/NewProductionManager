using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductCertificateTypeConfig : IEntityTypeConfiguration<ProductCertificateType>
    {
        public void Configure(EntityTypeBuilder<ProductCertificateType> entity)
        {
            entity.HasKey(e => new { e.CertifcateType });
            entity.Property(e => e.CertifcateType).HasMaxLength(32); 
            entity.Property(e => e.Description).HasMaxLength(160); 
        }
    }
}