using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductAdditionalInfoByGuidQueryHandler  :  IRequestHandler<GetProductAdditionalInfoByGuidQuery, Either<GeneralFailure, ProductAdditionalInfoResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductAdditionalInfoByGuidQueryHandler> _logger;
        public IProductAdditionalInfoRepository _productAdditionalInfoRepository ;
        public GetProductAdditionalInfoByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductAdditionalInfoByGuidQueryHandler> logger, IProductAdditionalInfoRepository productAdditionalInfoRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productAdditionalInfoRepository = productAdditionalInfoRepository  ?? throw new ArgumentNullException(nameof(productAdditionalInfoRepository ));
        }

        public async Task<Either<GeneralFailure, ProductAdditionalInfoResponseDTO>> Handle(GetProductAdditionalInfoByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}