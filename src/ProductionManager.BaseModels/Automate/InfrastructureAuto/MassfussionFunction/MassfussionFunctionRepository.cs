using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  MassfussionFunctionRepository:GenericRepository<MassfussionFunction>, IMassfussionFunctionRepository
    {
        public   MassfussionFunctionRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}