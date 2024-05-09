using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductShippingEventCommandHandler  :  IRequestHandler<CreateProductShippingEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductShippingEventCommandHandler> _logger;
        public IProductShippingEventRepository _productShippingEventRepository ;
        public CreateProductShippingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductShippingEventCommandHandler> logger, IProductShippingEventRepository productShippingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productShippingEventRepository = productShippingEventRepository  ?? throw new ArgumentNullException(nameof(productShippingEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductShippingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductShippingEvent.Create(request.productShippingEventCreateDTO.ProductShippingEventName, request.productShippingEventCreateDTO.Value.GuidId);return ( await  _productShippingEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}