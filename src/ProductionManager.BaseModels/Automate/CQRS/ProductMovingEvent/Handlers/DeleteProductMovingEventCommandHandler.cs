using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductMovingEventCommandHandler  :  IRequestHandler<DeleteProductMovingEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductMovingEventRepository _productMovingEventRepository ;
        private readonly ILogger<DeleteProductMovingEventCommandHandler> _logger;
        public DeleteProductMovingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductMovingEventCommandHandler> logger, IProductMovingEventRepository productMovingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productMovingEventRepository = productMovingEventRepository  ?? throw new ArgumentNullException(nameof(productMovingEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductMovingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productMovingEventRepository.DeleteByGuidAsync(request.DeleteProductMovingEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductMovingEventRepository.DeleteByGuidAsync(request.DeleteProductMovingEventDTO.guid, cancellationToken);
        }
    }
}