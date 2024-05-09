using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllDefectTypeSolutionQueryHandler  :  IRequestHandler<GetAllDefectTypeSolutionQuery, Either<GeneralFailure, IEnumerable<DefectTypeSolutionResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllDefectTypeSolutionQueryHandler> _logger;
        public GetAllDefectTypeSolutionQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllDefectTypeSolutionQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<DefectTypeSolutionResponseDTO>>> Handle(GetAllDefectTypeSolutionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}