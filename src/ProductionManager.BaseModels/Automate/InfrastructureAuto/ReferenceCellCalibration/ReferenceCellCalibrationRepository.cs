using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ReferenceCellCalibrationRepository:GenericRepository<ReferenceCellCalibration>, IReferenceCellCalibrationRepository
    {
        public   ReferenceCellCalibrationRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}