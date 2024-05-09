using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetReferenceCellCalibrationQueryHandler  :  IRequestHandler<GetReferenceCellCalibrationQuery, Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetReferenceCellCalibrationQueryHandler> _logger;
        public IReferenceCellCalibrationRepository _referenceCellCalibrationRepository ;
        public GetReferenceCellCalibrationQueryHandler(IUnitOfWork unitOfWork, ILogger<GetReferenceCellCalibrationQueryHandler> logger, IReferenceCellCalibrationRepository referenceCellCalibrationRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _referenceCellCalibrationRepository = referenceCellCalibrationRepository  ?? throw new ArgumentNullException(nameof(referenceCellCalibrationRepository ));
        }

        public async Task<Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>> Handle(GetReferenceCellCalibrationQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}