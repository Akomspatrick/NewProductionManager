using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  UsersGroupRepository:GenericRepository<UsersGroup>, IUsersGroupRepository
    {
        public   UsersGroupRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}