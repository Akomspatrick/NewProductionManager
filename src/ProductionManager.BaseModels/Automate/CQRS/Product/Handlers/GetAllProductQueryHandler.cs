using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductQueryHandler  :  IRequestHandler<GetAllProductQuery, Either<GeneralFailure, IEnumerable<ProductResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductQueryHandler> _logger;
        public IProductRepository _productRepository ;
        public GetAllProductQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductQueryHandler> logger, IProductRepository productRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productRepository = productRepository  ?? throw new ArgumentNullException(nameof(productRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductResponseDTO>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}