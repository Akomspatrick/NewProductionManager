using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductSurfacePreparationEventCommandHandler  :  IRequestHandler<CreateProductSurfacePreparationEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductSurfacePreparationEventCommandHandler> _logger;
        public IProductSurfacePreparationEventRepository _productSurfacePreparationEventRepository ;
        public CreateProductSurfacePreparationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductSurfacePreparationEventCommandHandler> logger, IProductSurfacePreparationEventRepository productSurfacePreparationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSurfacePreparationEventRepository = productSurfacePreparationEventRepository  ?? throw new ArgumentNullException(nameof(productSurfacePreparationEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductSurfacePreparationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductSurfacePreparationEvent.Create(request.productSurfacePreparationEventCreateDTO.ProductSurfacePreparationEventName, request.productSurfacePreparationEventCreateDTO.Value.GuidId);return ( await  _productSurfacePreparationEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}