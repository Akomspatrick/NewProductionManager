using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductSurfacePreparationEventQueryHandler  :  IRequestHandler<GetProductSurfacePreparationEventQuery, Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductSurfacePreparationEventQueryHandler> _logger;
        public GetProductSurfacePreparationEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductSurfacePreparationEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>> Handle(GetProductSurfacePreparationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}