using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasKey(e => new { e.ProductId });
            entity.Property(e => e.ModelName).HasMaxLength(32); 
            entity.Property(e => e.InvoiceId).HasMaxLength(32); 
            entity.Property(e => e.SalesOrderId).HasMaxLength(32); 
            entity.Property(e => e.TestingMode).HasMaxLength(32); 
            entity.Property(e => e.ProcessFlowGroupName).HasMaxLength(32); 
            entity.Property(e => e.ThermexPurcharseOrderNo).HasMaxLength(32); 
            entity.Property(e => e.MachiningPurcharseOrderNo).HasMaxLength(32); 
            entity.Property(e => e.SteelPurcharseOrderNo).HasMaxLength(32); 
            entity.Property(e => e.LoadDirection).HasMaxLength(32); 
            entity.HasOne<ModelVersion>(e => e.ModelVersion).WithMany(ad => ad.Products).HasForeignKey(e => new {e.ModelVersionId,e.ModelName});
        }
    }
}