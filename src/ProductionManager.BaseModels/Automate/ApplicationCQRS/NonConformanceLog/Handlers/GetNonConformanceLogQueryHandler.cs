using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetNonConformanceLogQueryHandler  :  IRequestHandler<GetNonConformanceLogQuery, Either<GeneralFailure, NonConformanceLogResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetNonConformanceLogQueryHandler> _logger;
        public GetNonConformanceLogQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetNonConformanceLogQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, NonConformanceLogResponseDTO>> Handle(GetNonConformanceLogQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}