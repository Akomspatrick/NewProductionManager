using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductStageCommandHandler  :  IRequestHandler<CreateProductStageCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductStageCommandHandler> _logger;
        public IProductStageRepository _productStageRepository ;
        public CreateProductStageCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductStageCommandHandler> logger, IProductStageRepository productStageRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productStageRepository = productStageRepository  ?? throw new ArgumentNullException(nameof(productStageRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductStageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductStage.Create(request.productStageCreateDTO.ProductStageName, request.productStageCreateDTO.Value.GuidId);return ( await  _productStageRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}