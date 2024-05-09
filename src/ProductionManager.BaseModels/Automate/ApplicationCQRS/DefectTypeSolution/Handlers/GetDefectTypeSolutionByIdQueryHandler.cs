using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetDefectTypeSolutionByIdQueryHandler  :  IRequestHandler<GetDefectTypeSolutionByIdQuery, Either<GeneralFailure, DefectTypeSolutionResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetDefectTypeSolutionByIdQueryHandler> _logger;
        public GetDefectTypeSolutionByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetDefectTypeSolutionByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, DefectTypeSolutionResponseDTO>> Handle(GetDefectTypeSolutionByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}