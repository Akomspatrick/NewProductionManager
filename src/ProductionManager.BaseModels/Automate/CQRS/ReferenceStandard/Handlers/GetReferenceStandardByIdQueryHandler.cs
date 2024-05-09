using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetReferenceStandardByIdQueryHandler  :  IRequestHandler<GetReferenceStandardByIdQuery, Either<GeneralFailure, ReferenceStandardResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetReferenceStandardByIdQueryHandler> _logger;
        public IReferenceStandardRepository _referenceStandardRepository ;
        public GetReferenceStandardByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetReferenceStandardByIdQueryHandler> logger, IReferenceStandardRepository referenceStandardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _referenceStandardRepository = referenceStandardRepository  ?? throw new ArgumentNullException(nameof(referenceStandardRepository ));
        }

        public async Task<Either<GeneralFailure, ReferenceStandardResponseDTO>> Handle(GetReferenceStandardByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}