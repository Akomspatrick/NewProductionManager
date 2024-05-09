using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductCablingEventRepository:GenericRepository<ProductCablingEvent>, IProductCablingEventRepository
    {
        public   ProductCablingEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}