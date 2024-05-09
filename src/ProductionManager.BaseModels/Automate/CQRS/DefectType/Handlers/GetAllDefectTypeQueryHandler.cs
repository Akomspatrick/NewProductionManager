using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllDefectTypeQueryHandler  :  IRequestHandler<GetAllDefectTypeQuery, Either<GeneralFailure, IEnumerable<DefectTypeResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllDefectTypeQueryHandler> _logger;
        public IDefectTypeRepository _defectTypeRepository ;
        public GetAllDefectTypeQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllDefectTypeQueryHandler> logger, IDefectTypeRepository defectTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeRepository = defectTypeRepository  ?? throw new ArgumentNullException(nameof(defectTypeRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<DefectTypeResponseDTO>>> Handle(GetAllDefectTypeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}