using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductPictureByGuidQueryHandler  :  IRequestHandler<GetProductPictureByGuidQuery, Either<GeneralFailure, ProductPictureResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductPictureByGuidQueryHandler> _logger;
        public IProductPictureRepository _productPictureRepository ;
        public GetProductPictureByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductPictureByGuidQueryHandler> logger, IProductPictureRepository productPictureRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productPictureRepository = productPictureRepository  ?? throw new ArgumentNullException(nameof(productPictureRepository ));
        }

        public async Task<Either<GeneralFailure, ProductPictureResponseDTO>> Handle(GetProductPictureByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}