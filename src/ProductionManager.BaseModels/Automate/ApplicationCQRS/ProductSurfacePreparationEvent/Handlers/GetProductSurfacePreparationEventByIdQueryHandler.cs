using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductSurfacePreparationEventByIdQueryHandler  :  IRequestHandler<GetProductSurfacePreparationEventByIdQuery, Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductSurfacePreparationEventByIdQueryHandler> _logger;
        public GetProductSurfacePreparationEventByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductSurfacePreparationEventByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>> Handle(GetProductSurfacePreparationEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}