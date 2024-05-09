using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetLogSummaryByIdQueryHandler  :  IRequestHandler<GetLogSummaryByIdQuery, Either<GeneralFailure, LogSummaryResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetLogSummaryByIdQueryHandler> _logger;
        public GetLogSummaryByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetLogSummaryByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, LogSummaryResponseDTO>> Handle(GetLogSummaryByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}