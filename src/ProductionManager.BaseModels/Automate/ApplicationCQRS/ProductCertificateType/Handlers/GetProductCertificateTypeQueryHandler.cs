using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCertificateTypeQueryHandler  :  IRequestHandler<GetProductCertificateTypeQuery, Either<GeneralFailure, ProductCertificateTypeResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductCertificateTypeQueryHandler> _logger;
        public GetProductCertificateTypeQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductCertificateTypeQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductCertificateTypeResponseDTO>> Handle(GetProductCertificateTypeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}