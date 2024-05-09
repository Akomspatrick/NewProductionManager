using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInventoryEventByGuidQueryHandler  :  IRequestHandler<GetProductInventoryEventByGuidQuery, Either<GeneralFailure, ProductInventoryEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductInventoryEventByGuidQueryHandler> _logger;
        public GetProductInventoryEventByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductInventoryEventByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductInventoryEventResponseDTO>> Handle(GetProductInventoryEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}