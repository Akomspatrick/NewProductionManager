using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductFinalUnitCommandHandler  :  IRequestHandler<CreateProductFinalUnitCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductFinalUnitCommandHandler> _logger;
        public IProductFinalUnitRepository _productFinalUnitRepository ;
        public CreateProductFinalUnitCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductFinalUnitCommandHandler> logger, IProductFinalUnitRepository productFinalUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalUnitRepository = productFinalUnitRepository  ?? throw new ArgumentNullException(nameof(productFinalUnitRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductFinalUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductFinalUnit.Create(request.productFinalUnitCreateDTO.ProductFinalUnitName, request.productFinalUnitCreateDTO.Value.GuidId);return ( await  _productFinalUnitRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}