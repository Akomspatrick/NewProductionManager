using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductMovingEventQueryHandler  :  IRequestHandler<GetProductMovingEventQuery, Either<GeneralFailure, ProductMovingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductMovingEventQueryHandler> _logger;
        public IProductMovingEventRepository _productMovingEventRepository ;
        public GetProductMovingEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductMovingEventQueryHandler> logger, IProductMovingEventRepository productMovingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productMovingEventRepository = productMovingEventRepository  ?? throw new ArgumentNullException(nameof(productMovingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductMovingEventResponseDTO>> Handle(GetProductMovingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}