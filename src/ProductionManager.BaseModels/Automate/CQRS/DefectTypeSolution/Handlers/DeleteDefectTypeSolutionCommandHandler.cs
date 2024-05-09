using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteDefectTypeSolutionCommandHandler  :  IRequestHandler<DeleteDefectTypeSolutionCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IDefectTypeSolutionRepository _defectTypeSolutionRepository ;
        private readonly ILogger<DeleteDefectTypeSolutionCommandHandler> _logger;
        public DeleteDefectTypeSolutionCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteDefectTypeSolutionCommandHandler> logger, IDefectTypeSolutionRepository defectTypeSolutionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeSolutionRepository = defectTypeSolutionRepository  ?? throw new ArgumentNullException(nameof(defectTypeSolutionRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteDefectTypeSolutionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _defectTypeSolutionRepository.DeleteByGuidAsync(request.DeleteDefectTypeSolutionDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.DefectTypeSolutionRepository.DeleteByGuidAsync(request.DeleteDefectTypeSolutionDTO.guid, cancellationToken);
        }
    }
}