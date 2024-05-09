using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class AmplifierBoardConfig : IEntityTypeConfiguration<AmplifierBoard>
    {
        public void Configure(EntityTypeBuilder<AmplifierBoard> entity)
        {
            entity.HasKey(e => new { e.AmplifierBoardId,e.Name });
            entity.Property(e => e.Brand).HasMaxLength(32); 
            entity.Property(e => e.Name).HasMaxLength(32); 
            entity.Property(e => e.RedValue).HasMaxLength(32); 
            entity.Property(e => e.GreenValue).HasMaxLength(32); 
            entity.Property(e => e.BlackValue).HasMaxLength(32); 
            entity.Property(e => e.WhiteValue).HasMaxLength(32); 
            entity.Property(e => e.ShieldValue).HasMaxLength(32); 
        }
    }
}