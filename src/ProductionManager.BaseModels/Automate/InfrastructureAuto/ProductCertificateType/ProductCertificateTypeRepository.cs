using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductCertificateTypeRepository:GenericRepository<ProductCertificateType>, IProductCertificateTypeRepository
    {
        public   ProductCertificateTypeRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}