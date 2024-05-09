using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCertificateQueryHandler  :  IRequestHandler<GetProductCertificateQuery, Either<GeneralFailure, ProductCertificateResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductCertificateQueryHandler> _logger;
        public IProductCertificateRepository _productCertificateRepository ;
        public GetProductCertificateQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductCertificateQueryHandler> logger, IProductCertificateRepository productCertificateRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateRepository = productCertificateRepository  ?? throw new ArgumentNullException(nameof(productCertificateRepository ));
        }

        public async Task<Either<GeneralFailure, ProductCertificateResponseDTO>> Handle(GetProductCertificateQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}