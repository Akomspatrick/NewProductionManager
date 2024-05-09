using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetDefectTypeSolutionQueryHandler  :  IRequestHandler<GetDefectTypeSolutionQuery, Either<GeneralFailure, DefectTypeSolutionResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetDefectTypeSolutionQueryHandler> _logger;
        public IDefectTypeSolutionRepository _defectTypeSolutionRepository ;
        public GetDefectTypeSolutionQueryHandler(IUnitOfWork unitOfWork, ILogger<GetDefectTypeSolutionQueryHandler> logger, IDefectTypeSolutionRepository defectTypeSolutionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeSolutionRepository = defectTypeSolutionRepository  ?? throw new ArgumentNullException(nameof(defectTypeSolutionRepository ));
        }

        public async Task<Either<GeneralFailure, DefectTypeSolutionResponseDTO>> Handle(GetDefectTypeSolutionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}