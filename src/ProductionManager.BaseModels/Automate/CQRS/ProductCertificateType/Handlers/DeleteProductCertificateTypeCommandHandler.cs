using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductCertificateTypeCommandHandler  :  IRequestHandler<DeleteProductCertificateTypeCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductCertificateTypeRepository _productCertificateTypeRepository ;
        private readonly ILogger<DeleteProductCertificateTypeCommandHandler> _logger;
        public DeleteProductCertificateTypeCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductCertificateTypeCommandHandler> logger, IProductCertificateTypeRepository productCertificateTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateTypeRepository = productCertificateTypeRepository  ?? throw new ArgumentNullException(nameof(productCertificateTypeRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductCertificateTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productCertificateTypeRepository.DeleteByGuidAsync(request.DeleteProductCertificateTypeDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductCertificateTypeRepository.DeleteByGuidAsync(request.DeleteProductCertificateTypeDTO.guid, cancellationToken);
        }
    }
}