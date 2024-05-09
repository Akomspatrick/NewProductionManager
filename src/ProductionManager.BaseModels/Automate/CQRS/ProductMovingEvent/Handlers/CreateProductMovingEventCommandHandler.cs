using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductMovingEventCommandHandler  :  IRequestHandler<CreateProductMovingEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductMovingEventCommandHandler> _logger;
        public IProductMovingEventRepository _productMovingEventRepository ;
        public CreateProductMovingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductMovingEventCommandHandler> logger, IProductMovingEventRepository productMovingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productMovingEventRepository = productMovingEventRepository  ?? throw new ArgumentNullException(nameof(productMovingEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductMovingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductMovingEvent.Create(request.productMovingEventCreateDTO.ProductMovingEventName, request.productMovingEventCreateDTO.Value.GuidId);return ( await  _productMovingEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}