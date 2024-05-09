using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllLogSummaryQueryHandler  :  IRequestHandler<GetAllLogSummaryQuery, Either<GeneralFailure, IEnumerable<LogSummaryResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllLogSummaryQueryHandler> _logger;
        public GetAllLogSummaryQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllLogSummaryQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<LogSummaryResponseDTO>>> Handle(GetAllLogSummaryQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}