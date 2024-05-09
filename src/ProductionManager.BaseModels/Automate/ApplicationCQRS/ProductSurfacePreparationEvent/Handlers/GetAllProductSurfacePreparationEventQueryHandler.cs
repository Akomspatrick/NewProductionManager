using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductSurfacePreparationEventQueryHandler  :  IRequestHandler<GetAllProductSurfacePreparationEventQuery, Either<GeneralFailure, IEnumerable<ProductSurfacePreparationEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductSurfacePreparationEventQueryHandler> _logger;
        public GetAllProductSurfacePreparationEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductSurfacePreparationEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductSurfacePreparationEventResponseDTO>>> Handle(GetAllProductSurfacePreparationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}