using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductResistorInstallationEventByGuidQueryHandler  :  IRequestHandler<GetProductResistorInstallationEventByGuidQuery, Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductResistorInstallationEventByGuidQueryHandler> _logger;
        public GetProductResistorInstallationEventByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductResistorInstallationEventByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>> Handle(GetProductResistorInstallationEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}