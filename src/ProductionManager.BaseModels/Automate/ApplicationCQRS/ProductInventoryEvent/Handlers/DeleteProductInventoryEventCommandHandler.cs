using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Commands;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductInventoryEventCommandHandler  :  IRequestHandler<DeleteProductInventoryEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<DeleteProductInventoryEventCommandHandler> _logger;
        public DeleteProductInventoryEventCommandHandler(IUnitOfWork unitOfWork, IAppLogger<DeleteProductInventoryEventCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductInventoryEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}