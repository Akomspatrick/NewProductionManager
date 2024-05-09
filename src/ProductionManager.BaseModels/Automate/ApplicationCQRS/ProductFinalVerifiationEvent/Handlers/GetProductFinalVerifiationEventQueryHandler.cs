using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinalVerifiationEventQueryHandler  :  IRequestHandler<GetProductFinalVerifiationEventQuery, Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductFinalVerifiationEventQueryHandler> _logger;
        public GetProductFinalVerifiationEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductFinalVerifiationEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>> Handle(GetProductFinalVerifiationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}