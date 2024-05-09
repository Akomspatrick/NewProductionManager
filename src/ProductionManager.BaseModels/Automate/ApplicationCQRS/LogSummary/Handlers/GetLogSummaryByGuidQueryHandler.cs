using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetLogSummaryByGuidQueryHandler  :  IRequestHandler<GetLogSummaryByGuidQuery, Either<GeneralFailure, LogSummaryResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetLogSummaryByGuidQueryHandler> _logger;
        public GetLogSummaryByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetLogSummaryByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, LogSummaryResponseDTO>> Handle(GetLogSummaryByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}