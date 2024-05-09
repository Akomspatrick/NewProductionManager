using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllDefectTypeSolutionQueryHandler  :  IRequestHandler<GetAllDefectTypeSolutionQuery, Either<GeneralFailure, IEnumerable<DefectTypeSolutionResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllDefectTypeSolutionQueryHandler> _logger;
        public IDefectTypeSolutionRepository _defectTypeSolutionRepository ;
        public GetAllDefectTypeSolutionQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllDefectTypeSolutionQueryHandler> logger, IDefectTypeSolutionRepository defectTypeSolutionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeSolutionRepository = defectTypeSolutionRepository  ?? throw new ArgumentNullException(nameof(defectTypeSolutionRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<DefectTypeSolutionResponseDTO>>> Handle(GetAllDefectTypeSolutionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}