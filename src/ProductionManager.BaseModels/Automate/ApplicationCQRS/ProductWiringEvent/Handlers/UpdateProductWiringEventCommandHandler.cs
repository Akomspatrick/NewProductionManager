using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Commands;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductWiringEventCommandHandler  :  IRequestHandler<UpdateProductWiringEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<UpdateProductWiringEventCommandHandler> _logger;
        public UpdateProductWiringEventCommandHandler(IUnitOfWork unitOfWork, IAppLogger<UpdateProductWiringEventCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductWiringEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}