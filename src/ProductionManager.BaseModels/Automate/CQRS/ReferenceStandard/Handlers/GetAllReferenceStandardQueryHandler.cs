using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllReferenceStandardQueryHandler  :  IRequestHandler<GetAllReferenceStandardQuery, Either<GeneralFailure, IEnumerable<ReferenceStandardResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllReferenceStandardQueryHandler> _logger;
        public IReferenceStandardRepository _referenceStandardRepository ;
        public GetAllReferenceStandardQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllReferenceStandardQueryHandler> logger, IReferenceStandardRepository referenceStandardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _referenceStandardRepository = referenceStandardRepository  ?? throw new ArgumentNullException(nameof(referenceStandardRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ReferenceStandardResponseDTO>>> Handle(GetAllReferenceStandardQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}