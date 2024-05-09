using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetDefectTypeSolutionByGuidQueryHandler  :  IRequestHandler<GetDefectTypeSolutionByGuidQuery, Either<GeneralFailure, DefectTypeSolutionResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetDefectTypeSolutionByGuidQueryHandler> _logger;
        public IDefectTypeSolutionRepository _defectTypeSolutionRepository ;
        public GetDefectTypeSolutionByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetDefectTypeSolutionByGuidQueryHandler> logger, IDefectTypeSolutionRepository defectTypeSolutionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeSolutionRepository = defectTypeSolutionRepository  ?? throw new ArgumentNullException(nameof(defectTypeSolutionRepository ));
        }

        public async Task<Either<GeneralFailure, DefectTypeSolutionResponseDTO>> Handle(GetDefectTypeSolutionByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}