using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProductInitialVerificationEventConfig : IEntityTypeConfiguration<ProductInitialVerificationEvent>
    {
        public void Configure(EntityTypeBuilder<ProductInitialVerificationEvent> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.TimeStamp });
            entity.Property(e => e.ReferenceSerial).HasMaxLength(32); 
            entity.Property(e => e.TesterName).HasMaxLength(32); 
            entity.Property(e => e.CalibratedOutput).HasPrecision(18,6); 
            entity.Property(e => e.PercentNonlinearity).HasPrecision(36,12); 
            entity.Property(e => e.DutZeroPoint).HasPrecision(18,6); 
            entity.Property(e => e.RefPoint1).HasPrecision(18,6); 
            entity.Property(e => e.ForcePoint1).HasPrecision(18,6); 
            entity.Property(e => e.DutPoint1).HasPrecision(18,6); 
            entity.Property(e => e.RefPoint2).HasPrecision(18,6); 
            entity.Property(e => e.ForcePoint2).HasPrecision(18,6); 
            entity.Property(e => e.DutPoint2).HasPrecision(18,6); 
            entity.Property(e => e.RefPoint3).HasPrecision(18,6); 
            entity.Property(e => e.ForcePoint3).HasPrecision(18,6); 
            entity.Property(e => e.DutPoint3).HasPrecision(18,6); 
            entity.Property(e => e.RefPoint4).HasPrecision(18,6); 
            entity.Property(e => e.ForcePoint4).HasPrecision(18,6); 
            entity.Property(e => e.DutPoint4).HasPrecision(18,6); 
            entity.Property(e => e.RefPoint5).HasPrecision(18,6); 
            entity.Property(e => e.ForcePoint5).HasPrecision(18,6); 
            entity.Property(e => e.DutPoint5).HasPrecision(18,6); 
            entity.Property(e => e.RefPoint6).HasPrecision(18,6); 
            entity.Property(e => e.ForcePoint6).HasPrecision(18,6); 
            entity.Property(e => e.DutPoint6).HasPrecision(18,6); 
            entity.Property(e => e.RefPoint7).HasPrecision(18,6); 
            entity.Property(e => e.ForcePoint7).HasPrecision(18,6); 
            entity.Property(e => e.DutPoint7).HasPrecision(18,6); 
            entity.Property(e => e.RefPoint8).HasPrecision(18,6); 
            entity.Property(e => e.ForcePoint8).HasPrecision(18,6); 
            entity.Property(e => e.DutPoint8).HasPrecision(18,6); 
            entity.Property(e => e.RefPoint9).HasPrecision(18,6); 
            entity.Property(e => e.ForcePoint9).HasPrecision(18,6); 
            entity.Property(e => e.DutPoint9).HasPrecision(18,6); 
            entity.Property(e => e.RefPoint10).HasPrecision(18,6); 
            entity.Property(e => e.ForcePoint10).HasPrecision(18,6); 
            entity.Property(e => e.DutPoint10).HasPrecision(18,6); 
            entity.Property(e => e.UserName).HasMaxLength(32); 
            entity.HasOne<Tester>(e => e.Tester).WithMany(ad => ad.ProductInitialVerificationEvents).HasForeignKey(e => new {e.TesterName});
        }
    }
}