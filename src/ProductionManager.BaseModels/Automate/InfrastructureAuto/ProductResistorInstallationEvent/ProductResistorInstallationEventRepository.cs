using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductResistorInstallationEventRepository:GenericRepository<ProductResistorInstallationEvent>, IProductResistorInstallationEventRepository
    {
        public   ProductResistorInstallationEventRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}