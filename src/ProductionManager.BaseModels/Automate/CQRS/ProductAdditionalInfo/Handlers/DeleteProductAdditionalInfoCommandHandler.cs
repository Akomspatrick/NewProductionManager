using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductAdditionalInfoCommandHandler  :  IRequestHandler<DeleteProductAdditionalInfoCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductAdditionalInfoRepository _productAdditionalInfoRepository ;
        private readonly ILogger<DeleteProductAdditionalInfoCommandHandler> _logger;
        public DeleteProductAdditionalInfoCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductAdditionalInfoCommandHandler> logger, IProductAdditionalInfoRepository productAdditionalInfoRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productAdditionalInfoRepository = productAdditionalInfoRepository  ?? throw new ArgumentNullException(nameof(productAdditionalInfoRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductAdditionalInfoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productAdditionalInfoRepository.DeleteByGuidAsync(request.DeleteProductAdditionalInfoDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductAdditionalInfoRepository.DeleteByGuidAsync(request.DeleteProductAdditionalInfoDTO.guid, cancellationToken);
        }
    }
}