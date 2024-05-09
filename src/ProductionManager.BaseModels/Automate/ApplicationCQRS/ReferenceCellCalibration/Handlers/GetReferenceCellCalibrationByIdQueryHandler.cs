using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetReferenceCellCalibrationByIdQueryHandler  :  IRequestHandler<GetReferenceCellCalibrationByIdQuery, Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetReferenceCellCalibrationByIdQueryHandler> _logger;
        public GetReferenceCellCalibrationByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetReferenceCellCalibrationByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>> Handle(GetReferenceCellCalibrationByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}