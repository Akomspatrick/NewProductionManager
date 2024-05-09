using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetDefectTypeQueryHandler  :  IRequestHandler<GetDefectTypeQuery, Either<GeneralFailure, DefectTypeResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetDefectTypeQueryHandler> _logger;
        public IDefectTypeRepository _defectTypeRepository ;
        public GetDefectTypeQueryHandler(IUnitOfWork unitOfWork, ILogger<GetDefectTypeQueryHandler> logger, IDefectTypeRepository defectTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeRepository = defectTypeRepository  ?? throw new ArgumentNullException(nameof(defectTypeRepository ));
        }

        public async Task<Either<GeneralFailure, DefectTypeResponseDTO>> Handle(GetDefectTypeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}