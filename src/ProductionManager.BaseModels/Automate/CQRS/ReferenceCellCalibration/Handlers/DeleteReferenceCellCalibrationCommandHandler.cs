using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteReferenceCellCalibrationCommandHandler  :  IRequestHandler<DeleteReferenceCellCalibrationCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IReferenceCellCalibrationRepository _referenceCellCalibrationRepository ;
        private readonly ILogger<DeleteReferenceCellCalibrationCommandHandler> _logger;
        public DeleteReferenceCellCalibrationCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteReferenceCellCalibrationCommandHandler> logger, IReferenceCellCalibrationRepository referenceCellCalibrationRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _referenceCellCalibrationRepository = referenceCellCalibrationRepository  ?? throw new ArgumentNullException(nameof(referenceCellCalibrationRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteReferenceCellCalibrationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _referenceCellCalibrationRepository.DeleteByGuidAsync(request.DeleteReferenceCellCalibrationDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ReferenceCellCalibrationRepository.DeleteByGuidAsync(request.DeleteReferenceCellCalibrationDTO.guid, cancellationToken);
        }
    }
}