using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  AmplifierBoardRepository:GenericRepository<AmplifierBoard>, IAmplifierBoardRepository
    {
        public   AmplifierBoardRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}