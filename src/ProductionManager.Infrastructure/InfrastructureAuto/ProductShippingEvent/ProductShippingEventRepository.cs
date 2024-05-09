using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductShippingEventRepository:GenericRepository<ProductShippingEvent>, IProductShippingEventRepository
    {
        public   ProductShippingEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}