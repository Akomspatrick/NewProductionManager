using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductRepository:GenericRepository<Product>, IProductRepository
    {
        public   ProductRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}