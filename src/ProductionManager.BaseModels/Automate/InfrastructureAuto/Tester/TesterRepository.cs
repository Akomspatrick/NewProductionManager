using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  TesterRepository:GenericRepository<Tester>, ITesterRepository
    {
        public   TesterRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}