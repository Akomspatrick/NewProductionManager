using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Commands;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductInventoryEventCommandHandler  :  IRequestHandler<UpdateProductInventoryEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<UpdateProductInventoryEventCommandHandler> _logger;
        public UpdateProductInventoryEventCommandHandler(IUnitOfWork unitOfWork, IAppLogger<UpdateProductInventoryEventCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductInventoryEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}