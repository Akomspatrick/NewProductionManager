using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductSealingEventRepository:GenericRepository<ProductSealingEvent>, IProductSealingEventRepository
    {
        public   ProductSealingEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}