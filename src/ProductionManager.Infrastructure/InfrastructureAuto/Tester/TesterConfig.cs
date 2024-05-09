using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class TesterConfig : IEntityTypeConfiguration<Tester>
    {
        public void Configure(EntityTypeBuilder<Tester> entity)
        {
            entity.HasKey(e => new { e.TesterName });
            entity.Property(e => e.TesterName).HasMaxLength(32); 
        }
    }
}