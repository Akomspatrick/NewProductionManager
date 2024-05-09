using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  NonConformanceLogRepository:GenericRepository<NonConformanceLog>, INonConformanceLogRepository
    {
        public   NonConformanceLogRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}