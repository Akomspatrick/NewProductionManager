using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductFinalUnitCommandHandler  :  IRequestHandler<DeleteProductFinalUnitCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductFinalUnitRepository _productFinalUnitRepository ;
        private readonly ILogger<DeleteProductFinalUnitCommandHandler> _logger;
        public DeleteProductFinalUnitCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductFinalUnitCommandHandler> logger, IProductFinalUnitRepository productFinalUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalUnitRepository = productFinalUnitRepository  ?? throw new ArgumentNullException(nameof(productFinalUnitRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductFinalUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productFinalUnitRepository.DeleteByGuidAsync(request.DeleteProductFinalUnitDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductFinalUnitRepository.DeleteByGuidAsync(request.DeleteProductFinalUnitDTO.guid, cancellationToken);
        }
    }
}