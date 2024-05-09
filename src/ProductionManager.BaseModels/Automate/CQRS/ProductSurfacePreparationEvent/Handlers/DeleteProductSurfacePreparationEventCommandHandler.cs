using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductSurfacePreparationEventCommandHandler  :  IRequestHandler<DeleteProductSurfacePreparationEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductSurfacePreparationEventRepository _productSurfacePreparationEventRepository ;
        private readonly ILogger<DeleteProductSurfacePreparationEventCommandHandler> _logger;
        public DeleteProductSurfacePreparationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductSurfacePreparationEventCommandHandler> logger, IProductSurfacePreparationEventRepository productSurfacePreparationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSurfacePreparationEventRepository = productSurfacePreparationEventRepository  ?? throw new ArgumentNullException(nameof(productSurfacePreparationEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductSurfacePreparationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productSurfacePreparationEventRepository.DeleteByGuidAsync(request.DeleteProductSurfacePreparationEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductSurfacePreparationEventRepository.DeleteByGuidAsync(request.DeleteProductSurfacePreparationEventDTO.guid, cancellationToken);
        }
    }
}