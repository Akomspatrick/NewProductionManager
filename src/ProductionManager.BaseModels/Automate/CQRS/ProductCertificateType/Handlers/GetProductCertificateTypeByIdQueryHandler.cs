using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCertificateTypeByIdQueryHandler  :  IRequestHandler<GetProductCertificateTypeByIdQuery, Either<GeneralFailure, ProductCertificateTypeResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductCertificateTypeByIdQueryHandler> _logger;
        public IProductCertificateTypeRepository _productCertificateTypeRepository ;
        public GetProductCertificateTypeByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductCertificateTypeByIdQueryHandler> logger, IProductCertificateTypeRepository productCertificateTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateTypeRepository = productCertificateTypeRepository  ?? throw new ArgumentNullException(nameof(productCertificateTypeRepository ));
        }

        public async Task<Either<GeneralFailure, ProductCertificateTypeResponseDTO>> Handle(GetProductCertificateTypeByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}