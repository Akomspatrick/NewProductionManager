using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductFinalVerifiationEventCommandHandler  :  IRequestHandler<DeleteProductFinalVerifiationEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductFinalVerifiationEventRepository _productFinalVerifiationEventRepository ;
        private readonly ILogger<DeleteProductFinalVerifiationEventCommandHandler> _logger;
        public DeleteProductFinalVerifiationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductFinalVerifiationEventCommandHandler> logger, IProductFinalVerifiationEventRepository productFinalVerifiationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalVerifiationEventRepository = productFinalVerifiationEventRepository  ?? throw new ArgumentNullException(nameof(productFinalVerifiationEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductFinalVerifiationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productFinalVerifiationEventRepository.DeleteByGuidAsync(request.DeleteProductFinalVerifiationEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductFinalVerifiationEventRepository.DeleteByGuidAsync(request.DeleteProductFinalVerifiationEventDTO.guid, cancellationToken);
        }
    }
}