using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductShippingEventCommandHandler  :  IRequestHandler<DeleteProductShippingEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductShippingEventRepository _productShippingEventRepository ;
        private readonly ILogger<DeleteProductShippingEventCommandHandler> _logger;
        public DeleteProductShippingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductShippingEventCommandHandler> logger, IProductShippingEventRepository productShippingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productShippingEventRepository = productShippingEventRepository  ?? throw new ArgumentNullException(nameof(productShippingEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductShippingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productShippingEventRepository.DeleteByGuidAsync(request.DeleteProductShippingEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductShippingEventRepository.DeleteByGuidAsync(request.DeleteProductShippingEventDTO.guid, cancellationToken);
        }
    }
}