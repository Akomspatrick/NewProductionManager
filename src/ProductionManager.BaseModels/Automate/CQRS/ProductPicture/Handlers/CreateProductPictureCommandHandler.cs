using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductPictureCommandHandler  :  IRequestHandler<CreateProductPictureCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductPictureCommandHandler> _logger;
        public IProductPictureRepository _productPictureRepository ;
        public CreateProductPictureCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductPictureCommandHandler> logger, IProductPictureRepository productPictureRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productPictureRepository = productPictureRepository  ?? throw new ArgumentNullException(nameof(productPictureRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductPictureCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductPicture.Create(request.productPictureCreateDTO.ProductPictureName, request.productPictureCreateDTO.Value.GuidId);return ( await  _productPictureRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}