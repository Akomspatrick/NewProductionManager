using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductCablingEventCommandHandler  :  IRequestHandler<DeleteProductCablingEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductCablingEventRepository _productCablingEventRepository ;
        private readonly ILogger<DeleteProductCablingEventCommandHandler> _logger;
        public DeleteProductCablingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductCablingEventCommandHandler> logger, IProductCablingEventRepository productCablingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCablingEventRepository = productCablingEventRepository  ?? throw new ArgumentNullException(nameof(productCablingEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductCablingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productCablingEventRepository.DeleteByGuidAsync(request.DeleteProductCablingEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductCablingEventRepository.DeleteByGuidAsync(request.DeleteProductCablingEventDTO.guid, cancellationToken);
        }
    }
}