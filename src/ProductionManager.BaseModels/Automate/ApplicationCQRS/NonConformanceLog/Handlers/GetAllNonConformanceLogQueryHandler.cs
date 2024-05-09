using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllNonConformanceLogQueryHandler  :  IRequestHandler<GetAllNonConformanceLogQuery, Either<GeneralFailure, IEnumerable<NonConformanceLogResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllNonConformanceLogQueryHandler> _logger;
        public GetAllNonConformanceLogQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllNonConformanceLogQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<NonConformanceLogResponseDTO>>> Handle(GetAllNonConformanceLogQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}