using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductMovingEventQueryHandler  :  IRequestHandler<GetAllProductMovingEventQuery, Either<GeneralFailure, IEnumerable<ProductMovingEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductMovingEventQueryHandler> _logger;
        public GetAllProductMovingEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductMovingEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductMovingEventResponseDTO>>> Handle(GetAllProductMovingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}