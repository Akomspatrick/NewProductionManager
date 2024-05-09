using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductCertificateTypeQueryHandler  :  IRequestHandler<GetAllProductCertificateTypeQuery, Either<GeneralFailure, IEnumerable<ProductCertificateTypeResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductCertificateTypeQueryHandler> _logger;
        public GetAllProductCertificateTypeQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductCertificateTypeQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductCertificateTypeResponseDTO>>> Handle(GetAllProductCertificateTypeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}