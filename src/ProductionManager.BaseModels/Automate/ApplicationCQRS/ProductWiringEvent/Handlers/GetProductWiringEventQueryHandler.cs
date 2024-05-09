using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductWiringEventQueryHandler  :  IRequestHandler<GetProductWiringEventQuery, Either<GeneralFailure, ProductWiringEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductWiringEventQueryHandler> _logger;
        public GetProductWiringEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductWiringEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductWiringEventResponseDTO>> Handle(GetProductWiringEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}