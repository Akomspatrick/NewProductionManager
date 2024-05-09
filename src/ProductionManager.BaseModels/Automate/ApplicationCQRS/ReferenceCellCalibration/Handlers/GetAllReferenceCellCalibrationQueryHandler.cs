using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllReferenceCellCalibrationQueryHandler  :  IRequestHandler<GetAllReferenceCellCalibrationQuery, Either<GeneralFailure, IEnumerable<ReferenceCellCalibrationResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllReferenceCellCalibrationQueryHandler> _logger;
        public GetAllReferenceCellCalibrationQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllReferenceCellCalibrationQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ReferenceCellCalibrationResponseDTO>>> Handle(GetAllReferenceCellCalibrationQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}