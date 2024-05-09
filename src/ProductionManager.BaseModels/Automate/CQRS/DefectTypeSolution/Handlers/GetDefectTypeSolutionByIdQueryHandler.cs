using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetDefectTypeSolutionByIdQueryHandler  :  IRequestHandler<GetDefectTypeSolutionByIdQuery, Either<GeneralFailure, DefectTypeSolutionResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetDefectTypeSolutionByIdQueryHandler> _logger;
        public IDefectTypeSolutionRepository _defectTypeSolutionRepository ;
        public GetDefectTypeSolutionByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetDefectTypeSolutionByIdQueryHandler> logger, IDefectTypeSolutionRepository defectTypeSolutionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeSolutionRepository = defectTypeSolutionRepository  ?? throw new ArgumentNullException(nameof(defectTypeSolutionRepository ));
        }

        public async Task<Either<GeneralFailure, DefectTypeSolutionResponseDTO>> Handle(GetDefectTypeSolutionByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}