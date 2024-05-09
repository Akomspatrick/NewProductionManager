using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductWiringEventCommandHandler  :  IRequestHandler<CreateProductWiringEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductWiringEventCommandHandler> _logger;
        public IProductWiringEventRepository _productWiringEventRepository ;
        public CreateProductWiringEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductWiringEventCommandHandler> logger, IProductWiringEventRepository productWiringEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productWiringEventRepository = productWiringEventRepository  ?? throw new ArgumentNullException(nameof(productWiringEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductWiringEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductWiringEvent.Create(request.productWiringEventCreateDTO.ProductWiringEventName, request.productWiringEventCreateDTO.Value.GuidId);return ( await  _productWiringEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}