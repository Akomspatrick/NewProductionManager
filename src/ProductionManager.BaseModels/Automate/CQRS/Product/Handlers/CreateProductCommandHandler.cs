using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductCommandHandler  :  IRequestHandler<CreateProductCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductCommandHandler> _logger;
        public IProductRepository _productRepository ;
        public CreateProductCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductCommandHandler> logger, IProductRepository productRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productRepository = productRepository  ?? throw new ArgumentNullException(nameof(productRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.Product.Create(request.productCreateDTO.ProductName, request.productCreateDTO.Value.GuidId);return ( await  _productRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}