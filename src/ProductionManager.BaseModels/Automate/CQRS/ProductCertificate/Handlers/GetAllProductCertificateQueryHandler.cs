using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductCertificateQueryHandler  :  IRequestHandler<GetAllProductCertificateQuery, Either<GeneralFailure, IEnumerable<ProductCertificateResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductCertificateQueryHandler> _logger;
        public IProductCertificateRepository _productCertificateRepository ;
        public GetAllProductCertificateQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductCertificateQueryHandler> logger, IProductCertificateRepository productCertificateRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateRepository = productCertificateRepository  ?? throw new ArgumentNullException(nameof(productCertificateRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductCertificateResponseDTO>>> Handle(GetAllProductCertificateQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}