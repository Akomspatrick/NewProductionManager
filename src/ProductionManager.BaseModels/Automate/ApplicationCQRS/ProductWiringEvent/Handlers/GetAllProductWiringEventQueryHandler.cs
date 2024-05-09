using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductWiringEventQueryHandler  :  IRequestHandler<GetAllProductWiringEventQuery, Either<GeneralFailure, IEnumerable<ProductWiringEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductWiringEventQueryHandler> _logger;
        public GetAllProductWiringEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductWiringEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductWiringEventResponseDTO>>> Handle(GetAllProductWiringEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}