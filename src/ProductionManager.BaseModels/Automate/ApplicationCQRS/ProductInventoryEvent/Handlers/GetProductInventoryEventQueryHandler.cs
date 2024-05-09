using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInventoryEventQueryHandler  :  IRequestHandler<GetProductInventoryEventQuery, Either<GeneralFailure, ProductInventoryEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductInventoryEventQueryHandler> _logger;
        public GetProductInventoryEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductInventoryEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductInventoryEventResponseDTO>> Handle(GetProductInventoryEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}