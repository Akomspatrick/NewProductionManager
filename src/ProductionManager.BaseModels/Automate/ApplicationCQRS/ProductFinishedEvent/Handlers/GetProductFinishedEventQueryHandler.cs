using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinishedEventQueryHandler  :  IRequestHandler<GetProductFinishedEventQuery, Either<GeneralFailure, ProductFinishedEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductFinishedEventQueryHandler> _logger;
        public GetProductFinishedEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductFinishedEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductFinishedEventResponseDTO>> Handle(GetProductFinishedEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}