using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinalVerifiationEventByIdQueryHandler  :  IRequestHandler<GetProductFinalVerifiationEventByIdQuery, Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductFinalVerifiationEventByIdQueryHandler> _logger;
        public GetProductFinalVerifiationEventByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductFinalVerifiationEventByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>> Handle(GetProductFinalVerifiationEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}