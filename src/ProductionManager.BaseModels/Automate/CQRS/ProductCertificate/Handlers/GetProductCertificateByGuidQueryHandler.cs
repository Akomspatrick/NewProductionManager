using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCertificateByGuidQueryHandler  :  IRequestHandler<GetProductCertificateByGuidQuery, Either<GeneralFailure, ProductCertificateResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductCertificateByGuidQueryHandler> _logger;
        public IProductCertificateRepository _productCertificateRepository ;
        public GetProductCertificateByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductCertificateByGuidQueryHandler> logger, IProductCertificateRepository productCertificateRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateRepository = productCertificateRepository  ?? throw new ArgumentNullException(nameof(productCertificateRepository ));
        }

        public async Task<Either<GeneralFailure, ProductCertificateResponseDTO>> Handle(GetProductCertificateByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}