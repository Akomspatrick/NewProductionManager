using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetReferenceStandardQueryHandler  :  IRequestHandler<GetReferenceStandardQuery, Either<GeneralFailure, ReferenceStandardResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetReferenceStandardQueryHandler> _logger;
        public GetReferenceStandardQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetReferenceStandardQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ReferenceStandardResponseDTO>> Handle(GetReferenceStandardQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}