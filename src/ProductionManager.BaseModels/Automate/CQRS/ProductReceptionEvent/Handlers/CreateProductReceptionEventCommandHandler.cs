using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductReceptionEventCommandHandler  :  IRequestHandler<CreateProductReceptionEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductReceptionEventCommandHandler> _logger;
        public IProductReceptionEventRepository _productReceptionEventRepository ;
        public CreateProductReceptionEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductReceptionEventCommandHandler> logger, IProductReceptionEventRepository productReceptionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productReceptionEventRepository = productReceptionEventRepository  ?? throw new ArgumentNullException(nameof(productReceptionEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductReceptionEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductReceptionEvent.Create(request.productReceptionEventCreateDTO.ProductReceptionEventName, request.productReceptionEventCreateDTO.Value.GuidId);return ( await  _productReceptionEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}