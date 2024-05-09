using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductByGuidQueryHandler  :  IRequestHandler<GetProductByGuidQuery, Either<GeneralFailure, ProductResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductByGuidQueryHandler> _logger;
        public IProductRepository _productRepository ;
        public GetProductByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductByGuidQueryHandler> logger, IProductRepository productRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productRepository = productRepository  ?? throw new ArgumentNullException(nameof(productRepository ));
        }

        public async Task<Either<GeneralFailure, ProductResponseDTO>> Handle(GetProductByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}