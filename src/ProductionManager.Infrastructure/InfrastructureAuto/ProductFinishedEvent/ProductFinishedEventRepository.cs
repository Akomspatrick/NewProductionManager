using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductFinishedEventRepository:GenericRepository<ProductFinishedEvent>, IProductFinishedEventRepository
    {
        public   ProductFinishedEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}