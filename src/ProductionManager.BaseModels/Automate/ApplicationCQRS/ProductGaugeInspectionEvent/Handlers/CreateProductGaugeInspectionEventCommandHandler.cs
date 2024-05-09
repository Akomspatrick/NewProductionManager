using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductGaugeInspectionEventCommandHandler  :  IRequestHandler<CreateProductGaugeInspectionEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<CreateProductGaugeInspectionEventCommandHandler> _logger;
        public CreateProductGaugeInspectionEventCommandHandler(IUnitOfWork unitOfWork, IAppLogger<CreateProductGaugeInspectionEventCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductGaugeInspectionEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductGaugeInspectionEvent.Create(request.modelTypeCreateDTO.ModelTypeName, request.modelTypeCreateDTO.Value.GuidId);return ( await _unitOfWork.ProductGaugeInspectionEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}