using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductByIdQueryHandler  :  IRequestHandler<GetProductByIdQuery, Either<GeneralFailure, ProductResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductByIdQueryHandler> _logger;
        public IProductRepository _productRepository ;
        public GetProductByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductByIdQueryHandler> logger, IProductRepository productRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productRepository = productRepository  ?? throw new ArgumentNullException(nameof(productRepository ));
        }

        public async Task<Either<GeneralFailure, ProductResponseDTO>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}