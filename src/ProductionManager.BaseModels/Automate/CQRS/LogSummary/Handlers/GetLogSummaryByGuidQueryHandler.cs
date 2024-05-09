using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetLogSummaryByGuidQueryHandler  :  IRequestHandler<GetLogSummaryByGuidQuery, Either<GeneralFailure, LogSummaryResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetLogSummaryByGuidQueryHandler> _logger;
        public ILogSummaryRepository _logSummaryRepository ;
        public GetLogSummaryByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetLogSummaryByGuidQueryHandler> logger, ILogSummaryRepository logSummaryRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logSummaryRepository = logSummaryRepository  ?? throw new ArgumentNullException(nameof(logSummaryRepository ));
        }

        public async Task<Either<GeneralFailure, LogSummaryResponseDTO>> Handle(GetLogSummaryByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}