using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductCertificateTypeCommandHandler  :  IRequestHandler<CreateProductCertificateTypeCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductCertificateTypeCommandHandler> _logger;
        public IProductCertificateTypeRepository _productCertificateTypeRepository ;
        public CreateProductCertificateTypeCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductCertificateTypeCommandHandler> logger, IProductCertificateTypeRepository productCertificateTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateTypeRepository = productCertificateTypeRepository  ?? throw new ArgumentNullException(nameof(productCertificateTypeRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductCertificateTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductCertificateType.Create(request.productCertificateTypeCreateDTO.ProductCertificateTypeName, request.productCertificateTypeCreateDTO.Value.GuidId);return ( await  _productCertificateTypeRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}