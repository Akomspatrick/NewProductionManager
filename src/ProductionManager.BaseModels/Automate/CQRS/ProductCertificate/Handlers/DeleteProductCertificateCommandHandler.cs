using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductCertificateCommandHandler  :  IRequestHandler<DeleteProductCertificateCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductCertificateRepository _productCertificateRepository ;
        private readonly ILogger<DeleteProductCertificateCommandHandler> _logger;
        public DeleteProductCertificateCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductCertificateCommandHandler> logger, IProductCertificateRepository productCertificateRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCertificateRepository = productCertificateRepository  ?? throw new ArgumentNullException(nameof(productCertificateRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductCertificateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productCertificateRepository.DeleteByGuidAsync(request.DeleteProductCertificateDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductCertificateRepository.DeleteByGuidAsync(request.DeleteProductCertificateDTO.guid, cancellationToken);
        }
    }
}