using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class UsersGroupConfig : IEntityTypeConfiguration<UsersGroup>
    {
        public void Configure(EntityTypeBuilder<UsersGroup> entity)
        {
        }
    }
}