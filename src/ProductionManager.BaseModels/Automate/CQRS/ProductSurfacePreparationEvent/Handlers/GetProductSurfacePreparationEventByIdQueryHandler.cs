using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductSurfacePreparationEventByIdQueryHandler  :  IRequestHandler<GetProductSurfacePreparationEventByIdQuery, Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductSurfacePreparationEventByIdQueryHandler> _logger;
        public IProductSurfacePreparationEventRepository _productSurfacePreparationEventRepository ;
        public GetProductSurfacePreparationEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductSurfacePreparationEventByIdQueryHandler> logger, IProductSurfacePreparationEventRepository productSurfacePreparationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSurfacePreparationEventRepository = productSurfacePreparationEventRepository  ?? throw new ArgumentNullException(nameof(productSurfacePreparationEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>> Handle(GetProductSurfacePreparationEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}