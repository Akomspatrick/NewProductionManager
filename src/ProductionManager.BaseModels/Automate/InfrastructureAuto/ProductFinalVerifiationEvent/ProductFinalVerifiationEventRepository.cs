using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductFinalVerifiationEventRepository:GenericRepository<ProductFinalVerifiationEvent>, IProductFinalVerifiationEventRepository
    {
        public   ProductFinalVerifiationEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}