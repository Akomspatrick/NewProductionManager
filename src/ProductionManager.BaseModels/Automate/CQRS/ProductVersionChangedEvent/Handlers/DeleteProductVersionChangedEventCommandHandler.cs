using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductVersionChangedEventCommandHandler  :  IRequestHandler<DeleteProductVersionChangedEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductVersionChangedEventRepository _productVersionChangedEventRepository ;
        private readonly ILogger<DeleteProductVersionChangedEventCommandHandler> _logger;
        public DeleteProductVersionChangedEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductVersionChangedEventCommandHandler> logger, IProductVersionChangedEventRepository productVersionChangedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productVersionChangedEventRepository = productVersionChangedEventRepository  ?? throw new ArgumentNullException(nameof(productVersionChangedEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductVersionChangedEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productVersionChangedEventRepository.DeleteByGuidAsync(request.DeleteProductVersionChangedEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductVersionChangedEventRepository.DeleteByGuidAsync(request.DeleteProductVersionChangedEventDTO.guid, cancellationToken);
        }
    }
}