using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductResistorInstallationEventCommandHandler  :  IRequestHandler<DeleteProductResistorInstallationEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductResistorInstallationEventRepository _productResistorInstallationEventRepository ;
        private readonly ILogger<DeleteProductResistorInstallationEventCommandHandler> _logger;
        public DeleteProductResistorInstallationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductResistorInstallationEventCommandHandler> logger, IProductResistorInstallationEventRepository productResistorInstallationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productResistorInstallationEventRepository = productResistorInstallationEventRepository  ?? throw new ArgumentNullException(nameof(productResistorInstallationEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductResistorInstallationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productResistorInstallationEventRepository.DeleteByGuidAsync(request.DeleteProductResistorInstallationEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductResistorInstallationEventRepository.DeleteByGuidAsync(request.DeleteProductResistorInstallationEventDTO.guid, cancellationToken);
        }
    }
}