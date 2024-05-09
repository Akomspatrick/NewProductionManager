using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductResistorInstallationEventByIdQueryHandler  :  IRequestHandler<GetProductResistorInstallationEventByIdQuery, Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductResistorInstallationEventByIdQueryHandler> _logger;
        public GetProductResistorInstallationEventByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductResistorInstallationEventByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>> Handle(GetProductResistorInstallationEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}