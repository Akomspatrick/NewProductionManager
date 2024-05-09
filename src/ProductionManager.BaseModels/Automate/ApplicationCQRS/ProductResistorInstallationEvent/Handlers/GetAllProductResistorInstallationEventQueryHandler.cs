using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductResistorInstallationEventQueryHandler  :  IRequestHandler<GetAllProductResistorInstallationEventQuery, Either<GeneralFailure, IEnumerable<ProductResistorInstallationEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductResistorInstallationEventQueryHandler> _logger;
        public GetAllProductResistorInstallationEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductResistorInstallationEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductResistorInstallationEventResponseDTO>>> Handle(GetAllProductResistorInstallationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}