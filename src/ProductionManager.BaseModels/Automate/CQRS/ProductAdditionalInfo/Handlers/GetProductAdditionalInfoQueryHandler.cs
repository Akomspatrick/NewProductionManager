using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductAdditionalInfoQueryHandler  :  IRequestHandler<GetProductAdditionalInfoQuery, Either<GeneralFailure, ProductAdditionalInfoResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductAdditionalInfoQueryHandler> _logger;
        public IProductAdditionalInfoRepository _productAdditionalInfoRepository ;
        public GetProductAdditionalInfoQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductAdditionalInfoQueryHandler> logger, IProductAdditionalInfoRepository productAdditionalInfoRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productAdditionalInfoRepository = productAdditionalInfoRepository  ?? throw new ArgumentNullException(nameof(productAdditionalInfoRepository ));
        }

        public async Task<Either<GeneralFailure, ProductAdditionalInfoResponseDTO>> Handle(GetProductAdditionalInfoQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}