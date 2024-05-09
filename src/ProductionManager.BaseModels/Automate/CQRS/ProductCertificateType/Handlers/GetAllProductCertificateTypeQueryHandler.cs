using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductCertificateTypeQueryHandler  :  IRequestHandler<GetAllProductCertificateTypeQuery, Either<GeneralFailure, IEnumerable<ProductCertificateTypeResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductCertificateTypeQueryHandler> _logger;
        public IProductCertificateTypeRepository _productCertificateTypeRepository ;
        public GetAllProductCertificateTypeQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductCertificateTypeQueryHandler> logger, IProductCertificateTypeRepository productCertificateTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateTypeRepository = productCertificateTypeRepository  ?? throw new ArgumentNullException(nameof(productCertificateTypeRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductCertificateTypeResponseDTO>>> Handle(GetAllProductCertificateTypeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}