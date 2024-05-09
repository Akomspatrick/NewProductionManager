using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Commands;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductReceptionEventCommandHandler  :  IRequestHandler<UpdateProductReceptionEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<UpdateProductReceptionEventCommandHandler> _logger;
        public UpdateProductReceptionEventCommandHandler(IUnitOfWork unitOfWork, IAppLogger<UpdateProductReceptionEventCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductReceptionEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}