using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductMovingEventByIdQueryHandler  :  IRequestHandler<GetProductMovingEventByIdQuery, Either<GeneralFailure, ProductMovingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductMovingEventByIdQueryHandler> _logger;
        public IProductMovingEventRepository _productMovingEventRepository ;
        public GetProductMovingEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductMovingEventByIdQueryHandler> logger, IProductMovingEventRepository productMovingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productMovingEventRepository = productMovingEventRepository  ?? throw new ArgumentNullException(nameof(productMovingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductMovingEventResponseDTO>> Handle(GetProductMovingEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}