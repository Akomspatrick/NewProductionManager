using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductWiringEventCommandHandler  :  IRequestHandler<DeleteProductWiringEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductWiringEventRepository _productWiringEventRepository ;
        private readonly ILogger<DeleteProductWiringEventCommandHandler> _logger;
        public DeleteProductWiringEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductWiringEventCommandHandler> logger, IProductWiringEventRepository productWiringEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productWiringEventRepository = productWiringEventRepository  ?? throw new ArgumentNullException(nameof(productWiringEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductWiringEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productWiringEventRepository.DeleteByGuidAsync(request.DeleteProductWiringEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductWiringEventRepository.DeleteByGuidAsync(request.DeleteProductWiringEventDTO.guid, cancellationToken);
        }
    }
}