using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductSealingEventCommandHandler  :  IRequestHandler<CreateProductSealingEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductSealingEventCommandHandler> _logger;
        public IProductSealingEventRepository _productSealingEventRepository ;
        public CreateProductSealingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductSealingEventCommandHandler> logger, IProductSealingEventRepository productSealingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSealingEventRepository = productSealingEventRepository  ?? throw new ArgumentNullException(nameof(productSealingEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductSealingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductSealingEvent.Create(request.productSealingEventCreateDTO.ProductSealingEventName, request.productSealingEventCreateDTO.Value.GuidId);return ( await  _productSealingEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}