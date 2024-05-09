using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetLogSummaryQueryHandler  :  IRequestHandler<GetLogSummaryQuery, Either<GeneralFailure, LogSummaryResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetLogSummaryQueryHandler> _logger;
        public ILogSummaryRepository _logSummaryRepository ;
        public GetLogSummaryQueryHandler(IUnitOfWork unitOfWork, ILogger<GetLogSummaryQueryHandler> logger, ILogSummaryRepository logSummaryRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logSummaryRepository = logSummaryRepository  ?? throw new ArgumentNullException(nameof(logSummaryRepository ));
        }

        public async Task<Either<GeneralFailure, LogSummaryResponseDTO>> Handle(GetLogSummaryQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}