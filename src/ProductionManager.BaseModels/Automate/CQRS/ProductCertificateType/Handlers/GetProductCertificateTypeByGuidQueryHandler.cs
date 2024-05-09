using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCertificateTypeByGuidQueryHandler  :  IRequestHandler<GetProductCertificateTypeByGuidQuery, Either<GeneralFailure, ProductCertificateTypeResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductCertificateTypeByGuidQueryHandler> _logger;
        public IProductCertificateTypeRepository _productCertificateTypeRepository ;
        public GetProductCertificateTypeByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductCertificateTypeByGuidQueryHandler> logger, IProductCertificateTypeRepository productCertificateTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateTypeRepository = productCertificateTypeRepository  ?? throw new ArgumentNullException(nameof(productCertificateTypeRepository ));
        }

        public async Task<Either<GeneralFailure, ProductCertificateTypeResponseDTO>> Handle(GetProductCertificateTypeByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}