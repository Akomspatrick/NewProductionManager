using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductFinishedEventCommandHandler  :  IRequestHandler<CreateProductFinishedEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductFinishedEventCommandHandler> _logger;
        public IProductFinishedEventRepository _productFinishedEventRepository ;
        public CreateProductFinishedEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductFinishedEventCommandHandler> logger, IProductFinishedEventRepository productFinishedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinishedEventRepository = productFinishedEventRepository  ?? throw new ArgumentNullException(nameof(productFinishedEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductFinishedEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductFinishedEvent.Create(request.productFinishedEventCreateDTO.ProductFinishedEventName, request.productFinishedEventCreateDTO.Value.GuidId);return ( await  _productFinishedEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}