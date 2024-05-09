using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductMovingEventRepository:GenericRepository<ProductMovingEvent>, IProductMovingEventRepository
    {
        public   ProductMovingEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}