using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductFinalVerifiationEventCommandHandler  :  IRequestHandler<CreateProductFinalVerifiationEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductFinalVerifiationEventCommandHandler> _logger;
        public IProductFinalVerifiationEventRepository _productFinalVerifiationEventRepository ;
        public CreateProductFinalVerifiationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductFinalVerifiationEventCommandHandler> logger, IProductFinalVerifiationEventRepository productFinalVerifiationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalVerifiationEventRepository = productFinalVerifiationEventRepository  ?? throw new ArgumentNullException(nameof(productFinalVerifiationEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductFinalVerifiationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductFinalVerifiationEvent.Create(request.productFinalVerifiationEventCreateDTO.ProductFinalVerifiationEventName, request.productFinalVerifiationEventCreateDTO.Value.GuidId);return ( await  _productFinalVerifiationEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}