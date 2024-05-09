using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductResistorInstallationEventByIdQueryHandler  :  IRequestHandler<GetProductResistorInstallationEventByIdQuery, Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductResistorInstallationEventByIdQueryHandler> _logger;
        public IProductResistorInstallationEventRepository _productResistorInstallationEventRepository ;
        public GetProductResistorInstallationEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductResistorInstallationEventByIdQueryHandler> logger, IProductResistorInstallationEventRepository productResistorInstallationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productResistorInstallationEventRepository = productResistorInstallationEventRepository  ?? throw new ArgumentNullException(nameof(productResistorInstallationEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>> Handle(GetProductResistorInstallationEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}