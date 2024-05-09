using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductAdditionalInfoQueryHandler  :  IRequestHandler<GetProductAdditionalInfoQuery, Either<GeneralFailure, ProductAdditionalInfoResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductAdditionalInfoQueryHandler> _logger;
        public GetProductAdditionalInfoQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductAdditionalInfoQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductAdditionalInfoResponseDTO>> Handle(GetProductAdditionalInfoQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}