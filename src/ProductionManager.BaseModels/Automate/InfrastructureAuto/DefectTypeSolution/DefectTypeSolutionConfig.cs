using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class DefectTypeSolutionConfig : IEntityTypeConfiguration<DefectTypeSolution>
    {
        public void Configure(EntityTypeBuilder<DefectTypeSolution> entity)
        {
            entity.HasKey(e => new { e.DefectName,e.Stage,e.Timestamp });
            entity.Property(e => e.DefectName).HasMaxLength(32); 
            entity.Property(e => e.Stage).HasMaxLength(32); 
            entity.Property(e => e.Solution).HasMaxLength(264); 
            entity.Property(e => e.UserName).HasMaxLength(32); 
            entity.HasOne<DefectType>(e => e.DefectType).WithMany(ad => ad.DefectTypeSolutions).HasForeignKey(e => new {e.DefectName,e.Stage});
        }
    }
}