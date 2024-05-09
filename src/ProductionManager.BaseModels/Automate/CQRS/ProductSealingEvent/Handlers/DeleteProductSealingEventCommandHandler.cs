using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductSealingEventCommandHandler  :  IRequestHandler<DeleteProductSealingEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductSealingEventRepository _productSealingEventRepository ;
        private readonly ILogger<DeleteProductSealingEventCommandHandler> _logger;
        public DeleteProductSealingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductSealingEventCommandHandler> logger, IProductSealingEventRepository productSealingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSealingEventRepository = productSealingEventRepository  ?? throw new ArgumentNullException(nameof(productSealingEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductSealingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productSealingEventRepository.DeleteByGuidAsync(request.DeleteProductSealingEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductSealingEventRepository.DeleteByGuidAsync(request.DeleteProductSealingEventDTO.guid, cancellationToken);
        }
    }
}