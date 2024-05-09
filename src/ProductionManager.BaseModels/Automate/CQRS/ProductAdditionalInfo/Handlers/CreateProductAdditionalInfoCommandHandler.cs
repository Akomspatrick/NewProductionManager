using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductAdditionalInfoCommandHandler  :  IRequestHandler<CreateProductAdditionalInfoCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductAdditionalInfoCommandHandler> _logger;
        public IProductAdditionalInfoRepository _productAdditionalInfoRepository ;
        public CreateProductAdditionalInfoCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductAdditionalInfoCommandHandler> logger, IProductAdditionalInfoRepository productAdditionalInfoRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productAdditionalInfoRepository = productAdditionalInfoRepository  ?? throw new ArgumentNullException(nameof(productAdditionalInfoRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductAdditionalInfoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductAdditionalInfo.Create(request.productAdditionalInfoCreateDTO.ProductAdditionalInfoName, request.productAdditionalInfoCreateDTO.Value.GuidId);return ( await  _productAdditionalInfoRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}