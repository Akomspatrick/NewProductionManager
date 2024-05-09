using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductQueryHandler  :  IRequestHandler<GetProductQuery, Either<GeneralFailure, ProductResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductQueryHandler> _logger;
        public IProductRepository _productRepository ;
        public GetProductQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductQueryHandler> logger, IProductRepository productRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productRepository = productRepository  ?? throw new ArgumentNullException(nameof(productRepository ));
        }

        public async Task<Either<GeneralFailure, ProductResponseDTO>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}