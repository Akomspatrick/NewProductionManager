using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllLogSummaryQueryHandler  :  IRequestHandler<GetAllLogSummaryQuery, Either<GeneralFailure, IEnumerable<LogSummaryResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllLogSummaryQueryHandler> _logger;
        public ILogSummaryRepository _logSummaryRepository ;
        public GetAllLogSummaryQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllLogSummaryQueryHandler> logger, ILogSummaryRepository logSummaryRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logSummaryRepository = logSummaryRepository  ?? throw new ArgumentNullException(nameof(logSummaryRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<LogSummaryResponseDTO>>> Handle(GetAllLogSummaryQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}