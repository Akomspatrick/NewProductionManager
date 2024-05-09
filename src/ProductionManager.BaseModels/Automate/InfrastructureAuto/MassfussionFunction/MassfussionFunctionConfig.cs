using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class MassfussionFunctionConfig : IEntityTypeConfiguration<MassfussionFunction>
    {
        public void Configure(EntityTypeBuilder<MassfussionFunction> entity)
        {
        }
    }
}