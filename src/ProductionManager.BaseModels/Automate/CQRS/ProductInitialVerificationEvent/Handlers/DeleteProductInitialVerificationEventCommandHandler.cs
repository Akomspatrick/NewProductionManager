using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductInitialVerificationEventCommandHandler  :  IRequestHandler<DeleteProductInitialVerificationEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductInitialVerificationEventRepository _productInitialVerificationEventRepository ;
        private readonly ILogger<DeleteProductInitialVerificationEventCommandHandler> _logger;
        public DeleteProductInitialVerificationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductInitialVerificationEventCommandHandler> logger, IProductInitialVerificationEventRepository productInitialVerificationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInitialVerificationEventRepository = productInitialVerificationEventRepository  ?? throw new ArgumentNullException(nameof(productInitialVerificationEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductInitialVerificationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productInitialVerificationEventRepository.DeleteByGuidAsync(request.DeleteProductInitialVerificationEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductInitialVerificationEventRepository.DeleteByGuidAsync(request.DeleteProductInitialVerificationEventDTO.guid, cancellationToken);
        }
    }
}