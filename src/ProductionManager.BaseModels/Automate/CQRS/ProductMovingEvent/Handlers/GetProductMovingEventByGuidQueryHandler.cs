using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductMovingEventByGuidQueryHandler  :  IRequestHandler<GetProductMovingEventByGuidQuery, Either<GeneralFailure, ProductMovingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductMovingEventByGuidQueryHandler> _logger;
        public IProductMovingEventRepository _productMovingEventRepository ;
        public GetProductMovingEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductMovingEventByGuidQueryHandler> logger, IProductMovingEventRepository productMovingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productMovingEventRepository = productMovingEventRepository  ?? throw new ArgumentNullException(nameof(productMovingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductMovingEventResponseDTO>> Handle(GetProductMovingEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}