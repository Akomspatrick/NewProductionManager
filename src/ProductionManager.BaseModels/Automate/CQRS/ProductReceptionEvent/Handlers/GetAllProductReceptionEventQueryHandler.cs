using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductReceptionEventQueryHandler  :  IRequestHandler<GetAllProductReceptionEventQuery, Either<GeneralFailure, IEnumerable<ProductReceptionEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductReceptionEventQueryHandler> _logger;
        public IProductReceptionEventRepository _productReceptionEventRepository ;
        public GetAllProductReceptionEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductReceptionEventQueryHandler> logger, IProductReceptionEventRepository productReceptionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productReceptionEventRepository = productReceptionEventRepository  ?? throw new ArgumentNullException(nameof(productReceptionEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductReceptionEventResponseDTO>>> Handle(GetAllProductReceptionEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}