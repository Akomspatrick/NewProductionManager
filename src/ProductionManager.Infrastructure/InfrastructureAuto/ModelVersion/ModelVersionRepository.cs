using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ModelVersionRepository:GenericRepository<ModelVersion>, IModelVersionRepository
    {
        public   ModelVersionRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}