using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetNonConformanceLogByGuidQueryHandler  :  IRequestHandler<GetNonConformanceLogByGuidQuery, Either<GeneralFailure, NonConformanceLogResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetNonConformanceLogByGuidQueryHandler> _logger;
        public GetNonConformanceLogByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetNonConformanceLogByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, NonConformanceLogResponseDTO>> Handle(GetNonConformanceLogByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}