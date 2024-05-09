using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetDefectTypeSolutionByGuidQueryHandler  :  IRequestHandler<GetDefectTypeSolutionByGuidQuery, Either<GeneralFailure, DefectTypeSolutionResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetDefectTypeSolutionByGuidQueryHandler> _logger;
        public GetDefectTypeSolutionByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetDefectTypeSolutionByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, DefectTypeSolutionResponseDTO>> Handle(GetDefectTypeSolutionByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}