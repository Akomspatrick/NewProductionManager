using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductInventoryEventRepository:GenericRepository<ProductInventoryEvent>, IProductInventoryEventRepository
    {
        public   ProductInventoryEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}