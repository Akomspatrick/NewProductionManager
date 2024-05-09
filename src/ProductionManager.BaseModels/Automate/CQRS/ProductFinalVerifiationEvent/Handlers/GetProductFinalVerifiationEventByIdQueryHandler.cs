using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinalVerifiationEventByIdQueryHandler  :  IRequestHandler<GetProductFinalVerifiationEventByIdQuery, Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductFinalVerifiationEventByIdQueryHandler> _logger;
        public IProductFinalVerifiationEventRepository _productFinalVerifiationEventRepository ;
        public GetProductFinalVerifiationEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductFinalVerifiationEventByIdQueryHandler> logger, IProductFinalVerifiationEventRepository productFinalVerifiationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalVerifiationEventRepository = productFinalVerifiationEventRepository  ?? throw new ArgumentNullException(nameof(productFinalVerifiationEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>> Handle(GetProductFinalVerifiationEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}