using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductFinalVerifiationEventQueryHandler  :  IRequestHandler<GetAllProductFinalVerifiationEventQuery, Either<GeneralFailure, IEnumerable<ProductFinalVerifiationEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductFinalVerifiationEventQueryHandler> _logger;
        public GetAllProductFinalVerifiationEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductFinalVerifiationEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductFinalVerifiationEventResponseDTO>>> Handle(GetAllProductFinalVerifiationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}