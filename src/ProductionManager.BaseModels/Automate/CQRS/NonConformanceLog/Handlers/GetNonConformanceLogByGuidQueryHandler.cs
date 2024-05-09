using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetNonConformanceLogByGuidQueryHandler  :  IRequestHandler<GetNonConformanceLogByGuidQuery, Either<GeneralFailure, NonConformanceLogResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetNonConformanceLogByGuidQueryHandler> _logger;
        public INonConformanceLogRepository _nonConformanceLogRepository ;
        public GetNonConformanceLogByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetNonConformanceLogByGuidQueryHandler> logger, INonConformanceLogRepository nonConformanceLogRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _nonConformanceLogRepository = nonConformanceLogRepository  ?? throw new ArgumentNullException(nameof(nonConformanceLogRepository ));
        }

        public async Task<Either<GeneralFailure, NonConformanceLogResponseDTO>> Handle(GetNonConformanceLogByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}