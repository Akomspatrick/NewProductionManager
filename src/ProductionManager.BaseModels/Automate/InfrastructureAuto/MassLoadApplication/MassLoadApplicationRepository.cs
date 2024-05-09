using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  MassLoadApplicationRepository:GenericRepository<MassLoadApplication>, IMassLoadApplicationRepository
    {
        public   MassLoadApplicationRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}