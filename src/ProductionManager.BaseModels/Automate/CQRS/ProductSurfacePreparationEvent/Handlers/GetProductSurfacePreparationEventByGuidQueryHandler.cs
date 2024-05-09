using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductSurfacePreparationEventByGuidQueryHandler  :  IRequestHandler<GetProductSurfacePreparationEventByGuidQuery, Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductSurfacePreparationEventByGuidQueryHandler> _logger;
        public IProductSurfacePreparationEventRepository _productSurfacePreparationEventRepository ;
        public GetProductSurfacePreparationEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductSurfacePreparationEventByGuidQueryHandler> logger, IProductSurfacePreparationEventRepository productSurfacePreparationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSurfacePreparationEventRepository = productSurfacePreparationEventRepository  ?? throw new ArgumentNullException(nameof(productSurfacePreparationEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>> Handle(GetProductSurfacePreparationEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}