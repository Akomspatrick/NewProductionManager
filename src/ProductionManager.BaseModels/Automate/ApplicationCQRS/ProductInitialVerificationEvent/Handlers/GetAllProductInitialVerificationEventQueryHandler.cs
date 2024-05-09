using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductInitialVerificationEventQueryHandler  :  IRequestHandler<GetAllProductInitialVerificationEventQuery, Either<GeneralFailure, IEnumerable<ProductInitialVerificationEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductInitialVerificationEventQueryHandler> _logger;
        public GetAllProductInitialVerificationEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductInitialVerificationEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductInitialVerificationEventResponseDTO>>> Handle(GetAllProductInitialVerificationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}