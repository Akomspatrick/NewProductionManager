using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  DefectTypeSolutionRepository:GenericRepository<DefectTypeSolution>, IDefectTypeSolutionRepository
    {
        public   DefectTypeSolutionRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}