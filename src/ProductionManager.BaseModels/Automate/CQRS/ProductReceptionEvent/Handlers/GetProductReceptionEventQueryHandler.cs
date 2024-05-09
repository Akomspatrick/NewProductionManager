using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductReceptionEventQueryHandler  :  IRequestHandler<GetProductReceptionEventQuery, Either<GeneralFailure, ProductReceptionEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductReceptionEventQueryHandler> _logger;
        public IProductReceptionEventRepository _productReceptionEventRepository ;
        public GetProductReceptionEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductReceptionEventQueryHandler> logger, IProductReceptionEventRepository productReceptionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productReceptionEventRepository = productReceptionEventRepository  ?? throw new ArgumentNullException(nameof(productReceptionEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductReceptionEventResponseDTO>> Handle(GetProductReceptionEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}