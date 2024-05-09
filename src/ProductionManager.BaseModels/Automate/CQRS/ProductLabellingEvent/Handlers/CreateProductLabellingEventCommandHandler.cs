using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductLabellingEventCommandHandler  :  IRequestHandler<CreateProductLabellingEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductLabellingEventCommandHandler> _logger;
        public IProductLabellingEventRepository _productLabellingEventRepository ;
        public CreateProductLabellingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductLabellingEventCommandHandler> logger, IProductLabellingEventRepository productLabellingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productLabellingEventRepository = productLabellingEventRepository  ?? throw new ArgumentNullException(nameof(productLabellingEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductLabellingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductLabellingEvent.Create(request.productLabellingEventCreateDTO.ProductLabellingEventName, request.productLabellingEventCreateDTO.Value.GuidId);return ( await  _productLabellingEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}