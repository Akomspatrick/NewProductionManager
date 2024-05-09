using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInitialVerificationEventByGuidQueryHandler  :  IRequestHandler<GetProductInitialVerificationEventByGuidQuery, Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductInitialVerificationEventByGuidQueryHandler> _logger;
        public IProductInitialVerificationEventRepository _productInitialVerificationEventRepository ;
        public GetProductInitialVerificationEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductInitialVerificationEventByGuidQueryHandler> logger, IProductInitialVerificationEventRepository productInitialVerificationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInitialVerificationEventRepository = productInitialVerificationEventRepository  ?? throw new ArgumentNullException(nameof(productInitialVerificationEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>> Handle(GetProductInitialVerificationEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}