using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductResistorInstallationEventCommandHandler  :  IRequestHandler<CreateProductResistorInstallationEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductResistorInstallationEventCommandHandler> _logger;
        public IProductResistorInstallationEventRepository _productResistorInstallationEventRepository ;
        public CreateProductResistorInstallationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductResistorInstallationEventCommandHandler> logger, IProductResistorInstallationEventRepository productResistorInstallationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productResistorInstallationEventRepository = productResistorInstallationEventRepository  ?? throw new ArgumentNullException(nameof(productResistorInstallationEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductResistorInstallationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductResistorInstallationEvent.Create(request.productResistorInstallationEventCreateDTO.ProductResistorInstallationEventName, request.productResistorInstallationEventCreateDTO.Value.GuidId);return ( await  _productResistorInstallationEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}