using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductAdditionalInfoQueryHandler  :  IRequestHandler<GetAllProductAdditionalInfoQuery, Either<GeneralFailure, IEnumerable<ProductAdditionalInfoResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductAdditionalInfoQueryHandler> _logger;
        public GetAllProductAdditionalInfoQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductAdditionalInfoQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductAdditionalInfoResponseDTO>>> Handle(GetAllProductAdditionalInfoQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}