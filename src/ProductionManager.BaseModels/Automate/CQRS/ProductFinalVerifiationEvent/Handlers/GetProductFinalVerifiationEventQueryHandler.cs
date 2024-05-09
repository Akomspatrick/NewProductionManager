using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinalVerifiationEventQueryHandler  :  IRequestHandler<GetProductFinalVerifiationEventQuery, Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductFinalVerifiationEventQueryHandler> _logger;
        public IProductFinalVerifiationEventRepository _productFinalVerifiationEventRepository ;
        public GetProductFinalVerifiationEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductFinalVerifiationEventQueryHandler> logger, IProductFinalVerifiationEventRepository productFinalVerifiationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalVerifiationEventRepository = productFinalVerifiationEventRepository  ?? throw new ArgumentNullException(nameof(productFinalVerifiationEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>> Handle(GetProductFinalVerifiationEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}