using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductInitialUnitCommandHandler  :  IRequestHandler<DeleteProductInitialUnitCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductInitialUnitRepository _productInitialUnitRepository ;
        private readonly ILogger<DeleteProductInitialUnitCommandHandler> _logger;
        public DeleteProductInitialUnitCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductInitialUnitCommandHandler> logger, IProductInitialUnitRepository productInitialUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInitialUnitRepository = productInitialUnitRepository  ?? throw new ArgumentNullException(nameof(productInitialUnitRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductInitialUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productInitialUnitRepository.DeleteByGuidAsync(request.DeleteProductInitialUnitDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductInitialUnitRepository.DeleteByGuidAsync(request.DeleteProductInitialUnitDTO.guid, cancellationToken);
        }
    }
}