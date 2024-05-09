using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetReferenceCellCalibrationByIdQueryHandler  :  IRequestHandler<GetReferenceCellCalibrationByIdQuery, Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetReferenceCellCalibrationByIdQueryHandler> _logger;
        public IReferenceCellCalibrationRepository _referenceCellCalibrationRepository ;
        public GetReferenceCellCalibrationByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetReferenceCellCalibrationByIdQueryHandler> logger, IReferenceCellCalibrationRepository referenceCellCalibrationRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _referenceCellCalibrationRepository = referenceCellCalibrationRepository  ?? throw new ArgumentNullException(nameof(referenceCellCalibrationRepository ));
        }

        public async Task<Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>> Handle(GetReferenceCellCalibrationByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}