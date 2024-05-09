using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductVersionChangedEventCommandHandler  :  IRequestHandler<CreateProductVersionChangedEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductVersionChangedEventCommandHandler> _logger;
        public IProductVersionChangedEventRepository _productVersionChangedEventRepository ;
        public CreateProductVersionChangedEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductVersionChangedEventCommandHandler> logger, IProductVersionChangedEventRepository productVersionChangedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productVersionChangedEventRepository = productVersionChangedEventRepository  ?? throw new ArgumentNullException(nameof(productVersionChangedEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductVersionChangedEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductVersionChangedEvent.Create(request.productVersionChangedEventCreateDTO.ProductVersionChangedEventName, request.productVersionChangedEventCreateDTO.Value.GuidId);return ( await  _productVersionChangedEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}