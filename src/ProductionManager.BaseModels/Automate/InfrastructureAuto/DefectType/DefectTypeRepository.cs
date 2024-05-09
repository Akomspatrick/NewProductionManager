using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  DefectTypeRepository:GenericRepository<DefectType>, IDefectTypeRepository
    {
        public   DefectTypeRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}