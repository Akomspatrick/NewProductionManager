using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  LogSummaryRepository:GenericRepository<LogSummary>, ILogSummaryRepository
    {
        public   LogSummaryRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}