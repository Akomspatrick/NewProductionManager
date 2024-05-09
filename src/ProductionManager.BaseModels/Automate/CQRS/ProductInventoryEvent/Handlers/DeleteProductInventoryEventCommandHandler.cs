using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductInventoryEventCommandHandler  :  IRequestHandler<DeleteProductInventoryEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductInventoryEventRepository _productInventoryEventRepository ;
        private readonly ILogger<DeleteProductInventoryEventCommandHandler> _logger;
        public DeleteProductInventoryEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductInventoryEventCommandHandler> logger, IProductInventoryEventRepository productInventoryEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInventoryEventRepository = productInventoryEventRepository  ?? throw new ArgumentNullException(nameof(productInventoryEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductInventoryEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productInventoryEventRepository.DeleteByGuidAsync(request.DeleteProductInventoryEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductInventoryEventRepository.DeleteByGuidAsync(request.DeleteProductInventoryEventDTO.guid, cancellationToken);
        }
    }
}