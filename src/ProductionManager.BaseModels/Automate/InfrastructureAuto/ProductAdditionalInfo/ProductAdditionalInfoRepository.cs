using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductAdditionalInfoRepository:GenericRepository<ProductAdditionalInfo>, IProductAdditionalInfoRepository
    {
        public   ProductAdditionalInfoRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}