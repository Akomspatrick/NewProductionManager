using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductGaugeEventCommandHandler  :  IRequestHandler<DeleteProductGaugeEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductGaugeEventRepository _productGaugeEventRepository ;
        private readonly ILogger<DeleteProductGaugeEventCommandHandler> _logger;
        public DeleteProductGaugeEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductGaugeEventCommandHandler> logger, IProductGaugeEventRepository productGaugeEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeEventRepository = productGaugeEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductGaugeEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productGaugeEventRepository.DeleteByGuidAsync(request.DeleteProductGaugeEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductGaugeEventRepository.DeleteByGuidAsync(request.DeleteProductGaugeEventDTO.guid, cancellationToken);
        }
    }
}