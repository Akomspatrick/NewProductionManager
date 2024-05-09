using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductReceptionEventRepository:GenericRepository<ProductReceptionEvent>, IProductReceptionEventRepository
    {
        public   ProductReceptionEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}