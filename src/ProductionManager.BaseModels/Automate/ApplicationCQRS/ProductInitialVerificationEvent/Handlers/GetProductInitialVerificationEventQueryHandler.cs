using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInitialVerificationEventQueryHandler  :  IRequestHandler<GetProductInitialVerificationEventQuery, Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductInitialVerificationEventQueryHandler> _logger;
        public GetProductInitialVerificationEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductInitialVerificationEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>> Handle(GetProductInitialVerificationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}