using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductVersionChangedEventRepository:GenericRepository<ProductVersionChangedEvent>, IProductVersionChangedEventRepository
    {
        public   ProductVersionChangedEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}