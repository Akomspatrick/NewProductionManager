using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class NonConformanceLogConfig : IEntityTypeConfiguration<NonConformanceLog>
    {
        public void Configure(EntityTypeBuilder<NonConformanceLog> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.ModelVersionId,e.Stage,e.WhenItOccurred });
            entity.Property(e => e.ModelName).HasMaxLength(32); 
            entity.Property(e => e.DefectName).HasMaxLength(32); 
            entity.Property(e => e.LogByUserName).HasMaxLength(32); 
            entity.Property(e => e.Status).HasMaxLength(32); 
            entity.Property(e => e.Solution).HasMaxLength(256); 
            entity.Property(e => e.ResolvedByUserName).HasMaxLength(32); 
            entity.Property(e => e.Comment).HasMaxLength(32); 
            entity.HasOne<Product>(e => e.Product).WithMany(ad => ad.NonConformanceLogs).HasForeignKey(e => new {e.ProductId});
        }
    }
}