using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetNonConformanceLogQueryHandler  :  IRequestHandler<GetNonConformanceLogQuery, Either<GeneralFailure, NonConformanceLogResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetNonConformanceLogQueryHandler> _logger;
        public INonConformanceLogRepository _nonConformanceLogRepository ;
        public GetNonConformanceLogQueryHandler(IUnitOfWork unitOfWork, ILogger<GetNonConformanceLogQueryHandler> logger, INonConformanceLogRepository nonConformanceLogRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _nonConformanceLogRepository = nonConformanceLogRepository  ?? throw new ArgumentNullException(nameof(nonConformanceLogRepository ));
        }

        public async Task<Either<GeneralFailure, NonConformanceLogResponseDTO>> Handle(GetNonConformanceLogQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}