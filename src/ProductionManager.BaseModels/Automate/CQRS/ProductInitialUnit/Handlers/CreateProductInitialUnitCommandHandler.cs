using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductInitialUnitCommandHandler  :  IRequestHandler<CreateProductInitialUnitCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductInitialUnitCommandHandler> _logger;
        public IProductInitialUnitRepository _productInitialUnitRepository ;
        public CreateProductInitialUnitCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductInitialUnitCommandHandler> logger, IProductInitialUnitRepository productInitialUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInitialUnitRepository = productInitialUnitRepository  ?? throw new ArgumentNullException(nameof(productInitialUnitRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductInitialUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductInitialUnit.Create(request.productInitialUnitCreateDTO.ProductInitialUnitName, request.productInitialUnitCreateDTO.Value.GuidId);return ( await  _productInitialUnitRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}