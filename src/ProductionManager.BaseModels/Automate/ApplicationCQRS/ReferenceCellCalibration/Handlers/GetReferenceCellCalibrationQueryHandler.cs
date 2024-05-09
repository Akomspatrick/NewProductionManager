using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetReferenceCellCalibrationQueryHandler  :  IRequestHandler<GetReferenceCellCalibrationQuery, Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetReferenceCellCalibrationQueryHandler> _logger;
        public GetReferenceCellCalibrationQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetReferenceCellCalibrationQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>> Handle(GetReferenceCellCalibrationQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}