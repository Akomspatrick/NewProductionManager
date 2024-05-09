using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductPictureByIdQueryHandler  :  IRequestHandler<GetProductPictureByIdQuery, Either<GeneralFailure, ProductPictureResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductPictureByIdQueryHandler> _logger;
        public IProductPictureRepository _productPictureRepository ;
        public GetProductPictureByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductPictureByIdQueryHandler> logger, IProductPictureRepository productPictureRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productPictureRepository = productPictureRepository  ?? throw new ArgumentNullException(nameof(productPictureRepository ));
        }

        public async Task<Either<GeneralFailure, ProductPictureResponseDTO>> Handle(GetProductPictureByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}