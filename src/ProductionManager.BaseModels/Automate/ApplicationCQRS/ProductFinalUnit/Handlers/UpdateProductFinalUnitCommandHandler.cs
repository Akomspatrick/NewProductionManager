using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Commands;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductFinalUnitCommandHandler  :  IRequestHandler<UpdateProductFinalUnitCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<UpdateProductFinalUnitCommandHandler> _logger;
        public UpdateProductFinalUnitCommandHandler(IUnitOfWork unitOfWork, IAppLogger<UpdateProductFinalUnitCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductFinalUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}