using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductLabellingEventRepository:GenericRepository<ProductLabellingEvent>, IProductLabellingEventRepository
    {
        public   ProductLabellingEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}