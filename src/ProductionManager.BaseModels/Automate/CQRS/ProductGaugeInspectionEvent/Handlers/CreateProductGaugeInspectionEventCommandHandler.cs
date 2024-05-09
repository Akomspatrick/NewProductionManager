using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductGaugeInspectionEventCommandHandler  :  IRequestHandler<CreateProductGaugeInspectionEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductGaugeInspectionEventCommandHandler> _logger;
        public IProductGaugeInspectionEventRepository _productGaugeInspectionEventRepository ;
        public CreateProductGaugeInspectionEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductGaugeInspectionEventCommandHandler> logger, IProductGaugeInspectionEventRepository productGaugeInspectionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeInspectionEventRepository = productGaugeInspectionEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeInspectionEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductGaugeInspectionEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductGaugeInspectionEvent.Create(request.productGaugeInspectionEventCreateDTO.ProductGaugeInspectionEventName, request.productGaugeInspectionEventCreateDTO.Value.GuidId);return ( await  _productGaugeInspectionEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}