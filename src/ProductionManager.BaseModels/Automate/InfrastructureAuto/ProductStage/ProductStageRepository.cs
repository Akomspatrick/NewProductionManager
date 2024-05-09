using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductStageRepository:GenericRepository<ProductStage>, IProductStageRepository
    {
        public   ProductStageRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}