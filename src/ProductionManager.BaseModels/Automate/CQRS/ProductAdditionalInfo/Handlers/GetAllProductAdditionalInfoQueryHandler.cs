using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductAdditionalInfoQueryHandler  :  IRequestHandler<GetAllProductAdditionalInfoQuery, Either<GeneralFailure, IEnumerable<ProductAdditionalInfoResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductAdditionalInfoQueryHandler> _logger;
        public IProductAdditionalInfoRepository _productAdditionalInfoRepository ;
        public GetAllProductAdditionalInfoQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductAdditionalInfoQueryHandler> logger, IProductAdditionalInfoRepository productAdditionalInfoRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productAdditionalInfoRepository = productAdditionalInfoRepository  ?? throw new ArgumentNullException(nameof(productAdditionalInfoRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductAdditionalInfoResponseDTO>>> Handle(GetAllProductAdditionalInfoQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}