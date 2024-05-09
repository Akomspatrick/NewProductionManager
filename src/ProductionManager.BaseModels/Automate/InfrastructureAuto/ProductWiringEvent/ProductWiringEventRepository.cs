using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductWiringEventRepository:GenericRepository<ProductWiringEvent>, IProductWiringEventRepository
    {
        public   ProductWiringEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}