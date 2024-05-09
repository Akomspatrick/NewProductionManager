using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class LogDetailConfig : IEntityTypeConfiguration<LogDetail>
    {
        public void Configure(EntityTypeBuilder<LogDetail> entity)
        {
            entity.HasKey(e => new { e.ProductId,e.LogSummaryId });
            entity.HasOne<LogSummary>(e => e.LogSummary).WithMany(ad => ad.LogDetails).HasForeignKey(e => new {e.LogSummaryId});
        }
    }
}