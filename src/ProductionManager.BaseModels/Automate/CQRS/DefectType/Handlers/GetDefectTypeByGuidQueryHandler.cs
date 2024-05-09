using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetDefectTypeByGuidQueryHandler  :  IRequestHandler<GetDefectTypeByGuidQuery, Either<GeneralFailure, DefectTypeResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetDefectTypeByGuidQueryHandler> _logger;
        public IDefectTypeRepository _defectTypeRepository ;
        public GetDefectTypeByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetDefectTypeByGuidQueryHandler> logger, IDefectTypeRepository defectTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeRepository = defectTypeRepository  ?? throw new ArgumentNullException(nameof(defectTypeRepository ));
        }

        public async Task<Either<GeneralFailure, DefectTypeResponseDTO>> Handle(GetDefectTypeByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}