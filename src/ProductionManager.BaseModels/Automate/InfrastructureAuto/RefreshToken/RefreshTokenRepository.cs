using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  RefreshTokenRepository:GenericRepository<RefreshToken>, IRefreshTokenRepository
    {
        public   RefreshTokenRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}