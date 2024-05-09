using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetReferenceStandardQueryHandler  :  IRequestHandler<GetReferenceStandardQuery, Either<GeneralFailure, ReferenceStandardResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetReferenceStandardQueryHandler> _logger;
        public IReferenceStandardRepository _referenceStandardRepository ;
        public GetReferenceStandardQueryHandler(IUnitOfWork unitOfWork, ILogger<GetReferenceStandardQueryHandler> logger, IReferenceStandardRepository referenceStandardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _referenceStandardRepository = referenceStandardRepository  ?? throw new ArgumentNullException(nameof(referenceStandardRepository ));
        }

        public async Task<Either<GeneralFailure, ReferenceStandardResponseDTO>> Handle(GetReferenceStandardQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}