using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductGaugeEventCommandHandler  :  IRequestHandler<CreateProductGaugeEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductGaugeEventCommandHandler> _logger;
        public IProductGaugeEventRepository _productGaugeEventRepository ;
        public CreateProductGaugeEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductGaugeEventCommandHandler> logger, IProductGaugeEventRepository productGaugeEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeEventRepository = productGaugeEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductGaugeEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductGaugeEvent.Create(request.productGaugeEventCreateDTO.ProductGaugeEventName, request.productGaugeEventCreateDTO.Value.GuidId);return ( await  _productGaugeEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}