using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ReferenceStandardRepository:GenericRepository<ReferenceStandard>, IReferenceStandardRepository
    {
        public   ReferenceStandardRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}