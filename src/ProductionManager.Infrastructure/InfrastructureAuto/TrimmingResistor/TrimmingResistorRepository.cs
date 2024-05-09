using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  TrimmingResistorRepository:GenericRepository<TrimmingResistor>, ITrimmingResistorRepository
    {
        public   TrimmingResistorRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}