using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllNonConformanceLogQueryHandler  :  IRequestHandler<GetAllNonConformanceLogQuery, Either<GeneralFailure, IEnumerable<NonConformanceLogResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllNonConformanceLogQueryHandler> _logger;
        public INonConformanceLogRepository _nonConformanceLogRepository ;
        public GetAllNonConformanceLogQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllNonConformanceLogQueryHandler> logger, INonConformanceLogRepository nonConformanceLogRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _nonConformanceLogRepository = nonConformanceLogRepository  ?? throw new ArgumentNullException(nameof(nonConformanceLogRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<NonConformanceLogResponseDTO>>> Handle(GetAllNonConformanceLogQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}