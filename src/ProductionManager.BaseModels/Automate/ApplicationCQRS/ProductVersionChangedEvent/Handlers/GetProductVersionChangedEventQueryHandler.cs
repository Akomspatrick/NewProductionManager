using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductVersionChangedEventQueryHandler  :  IRequestHandler<GetProductVersionChangedEventQuery, Either<GeneralFailure, ProductVersionChangedEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductVersionChangedEventQueryHandler> _logger;
        public GetProductVersionChangedEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductVersionChangedEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductVersionChangedEventResponseDTO>> Handle(GetProductVersionChangedEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}