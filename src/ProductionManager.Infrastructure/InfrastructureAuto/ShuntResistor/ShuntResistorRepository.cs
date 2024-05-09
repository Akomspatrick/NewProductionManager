using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ShuntResistorRepository:GenericRepository<ShuntResistor>, IShuntResistorRepository
    {
        public   ShuntResistorRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}