using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductWiringEventCommandHandler  :  IRequestHandler<CreateProductWiringEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<CreateProductWiringEventCommandHandler> _logger;
        public CreateProductWiringEventCommandHandler(IUnitOfWork unitOfWork, IAppLogger<CreateProductWiringEventCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductWiringEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductWiringEvent.Create(request.modelTypeCreateDTO.ModelTypeName, request.modelTypeCreateDTO.Value.GuidId);return ( await _unitOfWork.ProductWiringEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}