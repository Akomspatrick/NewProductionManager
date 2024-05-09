using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCertificateByIdQueryHandler  :  IRequestHandler<GetProductCertificateByIdQuery, Either<GeneralFailure, ProductCertificateResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductCertificateByIdQueryHandler> _logger;
        public IProductCertificateRepository _productCertificateRepository ;
        public GetProductCertificateByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductCertificateByIdQueryHandler> logger, IProductCertificateRepository productCertificateRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateRepository = productCertificateRepository  ?? throw new ArgumentNullException(nameof(productCertificateRepository ));
        }

        public async Task<Either<GeneralFailure, ProductCertificateResponseDTO>> Handle(GetProductCertificateByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}