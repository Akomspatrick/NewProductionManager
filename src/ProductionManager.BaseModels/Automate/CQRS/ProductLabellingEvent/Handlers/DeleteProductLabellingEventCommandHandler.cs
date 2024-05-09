using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductLabellingEventCommandHandler  :  IRequestHandler<DeleteProductLabellingEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductLabellingEventRepository _productLabellingEventRepository ;
        private readonly ILogger<DeleteProductLabellingEventCommandHandler> _logger;
        public DeleteProductLabellingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductLabellingEventCommandHandler> logger, IProductLabellingEventRepository productLabellingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productLabellingEventRepository = productLabellingEventRepository  ?? throw new ArgumentNullException(nameof(productLabellingEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductLabellingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productLabellingEventRepository.DeleteByGuidAsync(request.DeleteProductLabellingEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductLabellingEventRepository.DeleteByGuidAsync(request.DeleteProductLabellingEventDTO.guid, cancellationToken);
        }
    }
}