using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductMovingEventQueryHandler  :  IRequestHandler<GetAllProductMovingEventQuery, Either<GeneralFailure, IEnumerable<ProductMovingEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductMovingEventQueryHandler> _logger;
        public IProductMovingEventRepository _productMovingEventRepository ;
        public GetAllProductMovingEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductMovingEventQueryHandler> logger, IProductMovingEventRepository productMovingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productMovingEventRepository = productMovingEventRepository  ?? throw new ArgumentNullException(nameof(productMovingEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductMovingEventResponseDTO>>> Handle(GetAllProductMovingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}