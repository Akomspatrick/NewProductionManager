using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductFinishedEventCommandHandler  :  IRequestHandler<DeleteProductFinishedEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductFinishedEventRepository _productFinishedEventRepository ;
        private readonly ILogger<DeleteProductFinishedEventCommandHandler> _logger;
        public DeleteProductFinishedEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductFinishedEventCommandHandler> logger, IProductFinishedEventRepository productFinishedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinishedEventRepository = productFinishedEventRepository  ?? throw new ArgumentNullException(nameof(productFinishedEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductFinishedEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productFinishedEventRepository.DeleteByGuidAsync(request.DeleteProductFinishedEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductFinishedEventRepository.DeleteByGuidAsync(request.DeleteProductFinishedEventDTO.guid, cancellationToken);
        }
    }
}