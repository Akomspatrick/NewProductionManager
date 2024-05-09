using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinalVerifiationEventByGuidQueryHandler  :  IRequestHandler<GetProductFinalVerifiationEventByGuidQuery, Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductFinalVerifiationEventByGuidQueryHandler> _logger;
        public IProductFinalVerifiationEventRepository _productFinalVerifiationEventRepository ;
        public GetProductFinalVerifiationEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductFinalVerifiationEventByGuidQueryHandler> logger, IProductFinalVerifiationEventRepository productFinalVerifiationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalVerifiationEventRepository = productFinalVerifiationEventRepository  ?? throw new ArgumentNullException(nameof(productFinalVerifiationEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>> Handle(GetProductFinalVerifiationEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}