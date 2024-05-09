using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductPictureQueryHandler  :  IRequestHandler<GetProductPictureQuery, Either<GeneralFailure, ProductPictureResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductPictureQueryHandler> _logger;
        public IProductPictureRepository _productPictureRepository ;
        public GetProductPictureQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductPictureQueryHandler> logger, IProductPictureRepository productPictureRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productPictureRepository = productPictureRepository  ?? throw new ArgumentNullException(nameof(productPictureRepository ));
        }

        public async Task<Either<GeneralFailure, ProductPictureResponseDTO>> Handle(GetProductPictureQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}