using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductPictureRepository:GenericRepository<ProductPicture>, IProductPictureRepository
    {
        public   ProductPictureRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}