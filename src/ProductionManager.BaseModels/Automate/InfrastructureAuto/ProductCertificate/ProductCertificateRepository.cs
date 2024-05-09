using ProductionManager.Domain.Interfaces;
using ProductionManager.Domain.Entities;
namespace ProductionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProductCertificateRepository:GenericRepository<ProductCertificate>, IProductCertificateRepository
    {
        public   ProductCertificateRepository( ProductionManagerContext ctx): base(ctx)
        {}
    }
}