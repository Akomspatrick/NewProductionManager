using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCertificateTypeQueryHandler  :  IRequestHandler<GetProductCertificateTypeQuery, Either<GeneralFailure, ProductCertificateTypeResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductCertificateTypeQueryHandler> _logger;
        public IProductCertificateTypeRepository _productCertificateTypeRepository ;
        public GetProductCertificateTypeQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductCertificateTypeQueryHandler> logger, IProductCertificateTypeRepository productCertificateTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateTypeRepository = productCertificateTypeRepository  ?? throw new ArgumentNullException(nameof(productCertificateTypeRepository ));
        }

        public async Task<Either<GeneralFailure, ProductCertificateTypeResponseDTO>> Handle(GetProductCertificateTypeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}