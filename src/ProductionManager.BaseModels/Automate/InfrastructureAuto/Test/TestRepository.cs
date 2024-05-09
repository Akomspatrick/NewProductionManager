using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  TestRepository:GenericRepository<Test>, ITestRepository
    {
        public   TestRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}