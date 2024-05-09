using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductResistorInstallationEventQueryHandler  :  IRequestHandler<GetProductResistorInstallationEventQuery, Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductResistorInstallationEventQueryHandler> _logger;
        public IProductResistorInstallationEventRepository _productResistorInstallationEventRepository ;
        public GetProductResistorInstallationEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductResistorInstallationEventQueryHandler> logger, IProductResistorInstallationEventRepository productResistorInstallationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productResistorInstallationEventRepository = productResistorInstallationEventRepository  ?? throw new ArgumentNullException(nameof(productResistorInstallationEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>> Handle(GetProductResistorInstallationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}