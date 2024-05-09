using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductSurfacePreparationEventQueryHandler  :  IRequestHandler<GetAllProductSurfacePreparationEventQuery, Either<GeneralFailure, IEnumerable<ProductSurfacePreparationEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductSurfacePreparationEventQueryHandler> _logger;
        public IProductSurfacePreparationEventRepository _productSurfacePreparationEventRepository ;
        public GetAllProductSurfacePreparationEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductSurfacePreparationEventQueryHandler> logger, IProductSurfacePreparationEventRepository productSurfacePreparationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSurfacePreparationEventRepository = productSurfacePreparationEventRepository  ?? throw new ArgumentNullException(nameof(productSurfacePreparationEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductSurfacePreparationEventResponseDTO>>> Handle(GetAllProductSurfacePreparationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}