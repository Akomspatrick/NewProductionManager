using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductCablingEventCommandHandler  :  IRequestHandler<CreateProductCablingEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductCablingEventCommandHandler> _logger;
        public IProductCablingEventRepository _productCablingEventRepository ;
        public CreateProductCablingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductCablingEventCommandHandler> logger, IProductCablingEventRepository productCablingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCablingEventRepository = productCablingEventRepository  ?? throw new ArgumentNullException(nameof(productCablingEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductCablingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductCablingEvent.Create(request.productCablingEventCreateDTO.ProductCablingEventName, request.productCablingEventCreateDTO.Value.GuidId);return ( await  _productCablingEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}