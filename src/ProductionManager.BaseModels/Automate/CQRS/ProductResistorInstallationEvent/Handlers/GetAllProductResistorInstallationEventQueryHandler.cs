using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductResistorInstallationEventQueryHandler  :  IRequestHandler<GetAllProductResistorInstallationEventQuery, Either<GeneralFailure, IEnumerable<ProductResistorInstallationEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductResistorInstallationEventQueryHandler> _logger;
        public IProductResistorInstallationEventRepository _productResistorInstallationEventRepository ;
        public GetAllProductResistorInstallationEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductResistorInstallationEventQueryHandler> logger, IProductResistorInstallationEventRepository productResistorInstallationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productResistorInstallationEventRepository = productResistorInstallationEventRepository  ?? throw new ArgumentNullException(nameof(productResistorInstallationEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductResistorInstallationEventResponseDTO>>> Handle(GetAllProductResistorInstallationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}