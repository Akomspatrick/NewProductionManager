using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductGaugeEventRepository:GenericRepository<ProductGaugeEvent>, IProductGaugeEventRepository
    {
        public   ProductGaugeEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}