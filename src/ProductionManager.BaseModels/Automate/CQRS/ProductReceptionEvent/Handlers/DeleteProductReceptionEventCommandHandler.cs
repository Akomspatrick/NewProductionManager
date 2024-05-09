using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductReceptionEventCommandHandler  :  IRequestHandler<DeleteProductReceptionEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductReceptionEventRepository _productReceptionEventRepository ;
        private readonly ILogger<DeleteProductReceptionEventCommandHandler> _logger;
        public DeleteProductReceptionEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductReceptionEventCommandHandler> logger, IProductReceptionEventRepository productReceptionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productReceptionEventRepository = productReceptionEventRepository  ?? throw new ArgumentNullException(nameof(productReceptionEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductReceptionEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productReceptionEventRepository.DeleteByGuidAsync(request.DeleteProductReceptionEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductReceptionEventRepository.DeleteByGuidAsync(request.DeleteProductReceptionEventDTO.guid, cancellationToken);
        }
    }
}