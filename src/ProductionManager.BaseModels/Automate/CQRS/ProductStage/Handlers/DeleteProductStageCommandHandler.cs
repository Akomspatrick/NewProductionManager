using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductStageCommandHandler  :  IRequestHandler<DeleteProductStageCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductStageRepository _productStageRepository ;
        private readonly ILogger<DeleteProductStageCommandHandler> _logger;
        public DeleteProductStageCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductStageCommandHandler> logger, IProductStageRepository productStageRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productStageRepository = productStageRepository  ?? throw new ArgumentNullException(nameof(productStageRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductStageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productStageRepository.DeleteByGuidAsync(request.DeleteProductStageDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductStageRepository.DeleteByGuidAsync(request.DeleteProductStageDTO.guid, cancellationToken);
        }
    }
}