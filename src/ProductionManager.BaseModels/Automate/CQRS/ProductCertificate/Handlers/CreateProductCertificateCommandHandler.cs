using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductCertificateCommandHandler  :  IRequestHandler<CreateProductCertificateCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductCertificateCommandHandler> _logger;
        public IProductCertificateRepository _productCertificateRepository ;
        public CreateProductCertificateCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductCertificateCommandHandler> logger, IProductCertificateRepository productCertificateRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateRepository = productCertificateRepository  ?? throw new ArgumentNullException(nameof(productCertificateRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductCertificateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductCertificate.Create(request.productCertificateCreateDTO.ProductCertificateName, request.productCertificateCreateDTO.Value.GuidId);return ( await  _productCertificateRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}