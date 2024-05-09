using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteDefectTypeCommandHandler  :  IRequestHandler<DeleteDefectTypeCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IDefectTypeRepository _defectTypeRepository ;
        private readonly ILogger<DeleteDefectTypeCommandHandler> _logger;
        public DeleteDefectTypeCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteDefectTypeCommandHandler> logger, IDefectTypeRepository defectTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeRepository = defectTypeRepository  ?? throw new ArgumentNullException(nameof(defectTypeRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteDefectTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _defectTypeRepository.DeleteByGuidAsync(request.DeleteDefectTypeDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.DefectTypeRepository.DeleteByGuidAsync(request.DeleteDefectTypeDTO.guid, cancellationToken);
        }
    }
}