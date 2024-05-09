using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class LogSummaryConfig : IEntityTypeConfiguration<LogSummary>
    {
        public void Configure(EntityTypeBuilder<LogSummary> entity)
        {
            entity.HasKey(e => new { e.LogSummaryId });
            entity.Property(e => e.Stage).HasMaxLength(32); 
            entity.Property(e => e.UserName).HasMaxLength(32); 
        }
    }
}