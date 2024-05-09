using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductPictureQueryHandler  :  IRequestHandler<GetAllProductPictureQuery, Either<GeneralFailure, IEnumerable<ProductPictureResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductPictureQueryHandler> _logger;
        public IProductPictureRepository _productPictureRepository ;
        public GetAllProductPictureQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductPictureQueryHandler> logger, IProductPictureRepository productPictureRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productPictureRepository = productPictureRepository  ?? throw new ArgumentNullException(nameof(productPictureRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductPictureResponseDTO>>> Handle(GetAllProductPictureQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}