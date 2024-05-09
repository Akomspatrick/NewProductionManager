using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductInitialVerificationEventRepository:GenericRepository<ProductInitialVerificationEvent>, IProductInitialVerificationEventRepository
    {
        public   ProductInitialVerificationEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}