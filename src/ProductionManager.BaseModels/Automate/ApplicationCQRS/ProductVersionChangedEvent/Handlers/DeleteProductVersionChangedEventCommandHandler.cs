using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Commands;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductVersionChangedEventCommandHandler  :  IRequestHandler<DeleteProductVersionChangedEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<DeleteProductVersionChangedEventCommandHandler> _logger;
        public DeleteProductVersionChangedEventCommandHandler(IUnitOfWork unitOfWork, IAppLogger<DeleteProductVersionChangedEventCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductVersionChangedEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}