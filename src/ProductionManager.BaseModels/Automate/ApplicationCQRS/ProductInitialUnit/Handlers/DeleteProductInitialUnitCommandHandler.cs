using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Commands;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductInitialUnitCommandHandler  :  IRequestHandler<DeleteProductInitialUnitCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<DeleteProductInitialUnitCommandHandler> _logger;
        public DeleteProductInitialUnitCommandHandler(IUnitOfWork unitOfWork, IAppLogger<DeleteProductInitialUnitCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductInitialUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}