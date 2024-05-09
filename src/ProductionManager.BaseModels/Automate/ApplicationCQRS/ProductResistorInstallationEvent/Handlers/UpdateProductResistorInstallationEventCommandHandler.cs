using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Commands;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductResistorInstallationEventCommandHandler  :  IRequestHandler<UpdateProductResistorInstallationEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<UpdateProductResistorInstallationEventCommandHandler> _logger;
        public UpdateProductResistorInstallationEventCommandHandler(IUnitOfWork unitOfWork, IAppLogger<UpdateProductResistorInstallationEventCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductResistorInstallationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}