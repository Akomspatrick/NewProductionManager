using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInitialVerificationEventQueryHandler  :  IRequestHandler<GetProductInitialVerificationEventQuery, Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductInitialVerificationEventQueryHandler> _logger;
        public IProductInitialVerificationEventRepository _productInitialVerificationEventRepository ;
        public GetProductInitialVerificationEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductInitialVerificationEventQueryHandler> logger, IProductInitialVerificationEventRepository productInitialVerificationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInitialVerificationEventRepository = productInitialVerificationEventRepository  ?? throw new ArgumentNullException(nameof(productInitialVerificationEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>> Handle(GetProductInitialVerificationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}