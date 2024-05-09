using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductCertificateQueryHandler  :  IRequestHandler<GetAllProductCertificateQuery, Either<GeneralFailure, IEnumerable<ProductCertificateResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductCertificateQueryHandler> _logger;
        public GetAllProductCertificateQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductCertificateQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductCertificateResponseDTO>>> Handle(GetAllProductCertificateQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}