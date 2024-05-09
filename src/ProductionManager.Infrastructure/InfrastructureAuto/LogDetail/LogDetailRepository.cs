using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  LogDetailRepository:GenericRepository<LogDetail>, ILogDetailRepository
    {
        public   LogDetailRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}