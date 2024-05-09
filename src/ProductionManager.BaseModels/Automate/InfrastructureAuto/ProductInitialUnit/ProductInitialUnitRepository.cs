using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductInitialUnitRepository:GenericRepository<ProductInitialUnit>, IProductInitialUnitRepository
    {
        public   ProductInitialUnitRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}