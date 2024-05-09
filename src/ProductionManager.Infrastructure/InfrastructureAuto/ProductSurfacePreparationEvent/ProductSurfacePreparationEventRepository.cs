using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductSurfacePreparationEventRepository:GenericRepository<ProductSurfacePreparationEvent>, IProductSurfacePreparationEventRepository
    {
        public   ProductSurfacePreparationEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}