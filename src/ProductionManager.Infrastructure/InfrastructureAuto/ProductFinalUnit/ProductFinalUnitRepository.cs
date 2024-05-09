using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductFinalUnitRepository:GenericRepository<ProductFinalUnit>, IProductFinalUnitRepository
    {
        public   ProductFinalUnitRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}