using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductPictureCommandHandler  :  IRequestHandler<DeleteProductPictureCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductPictureRepository _productPictureRepository ;
        private readonly ILogger<DeleteProductPictureCommandHandler> _logger;
        public DeleteProductPictureCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductPictureCommandHandler> logger, IProductPictureRepository productPictureRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productPictureRepository = productPictureRepository  ?? throw new ArgumentNullException(nameof(productPictureRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductPictureCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productPictureRepository.DeleteByGuidAsync(request.DeleteProductPictureDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductPictureRepository.DeleteByGuidAsync(request.DeleteProductPictureDTO.guid, cancellationToken);
        }
    }
}