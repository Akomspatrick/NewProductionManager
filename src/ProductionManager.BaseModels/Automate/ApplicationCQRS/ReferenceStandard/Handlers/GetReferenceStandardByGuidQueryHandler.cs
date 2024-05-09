using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetReferenceStandardByGuidQueryHandler  :  IRequestHandler<GetReferenceStandardByGuidQuery, Either<GeneralFailure, ReferenceStandardResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetReferenceStandardByGuidQueryHandler> _logger;
        public GetReferenceStandardByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetReferenceStandardByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ReferenceStandardResponseDTO>> Handle(GetReferenceStandardByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}