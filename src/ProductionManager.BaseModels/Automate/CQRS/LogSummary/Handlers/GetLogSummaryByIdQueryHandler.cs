using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetLogSummaryByIdQueryHandler  :  IRequestHandler<GetLogSummaryByIdQuery, Either<GeneralFailure, LogSummaryResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetLogSummaryByIdQueryHandler> _logger;
        public ILogSummaryRepository _logSummaryRepository ;
        public GetLogSummaryByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetLogSummaryByIdQueryHandler> logger, ILogSummaryRepository logSummaryRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logSummaryRepository = logSummaryRepository  ?? throw new ArgumentNullException(nameof(logSummaryRepository ));
        }

        public async Task<Either<GeneralFailure, LogSummaryResponseDTO>> Handle(GetLogSummaryByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}