using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductCommandHandler  :  IRequestHandler<DeleteProductCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductRepository _productRepository ;
        private readonly ILogger<DeleteProductCommandHandler> _logger;
        public DeleteProductCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductCommandHandler> logger, IProductRepository productRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productRepository = productRepository  ?? throw new ArgumentNullException(nameof(productRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productRepository.DeleteByGuidAsync(request.DeleteProductDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductRepository.DeleteByGuidAsync(request.DeleteProductDTO.guid, cancellationToken);
        }
    }
}