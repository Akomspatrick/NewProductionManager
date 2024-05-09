using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductGaugeInspectionEventRepository:GenericRepository<ProductGaugeInspectionEvent>, IProductGaugeInspectionEventRepository
    {
        public   ProductGaugeInspectionEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}