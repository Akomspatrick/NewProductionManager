using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductReceptionEventByIdQueryHandler  :  IRequestHandler<GetProductReceptionEventByIdQuery, Either<GeneralFailure, ProductReceptionEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductReceptionEventByIdQueryHandler> _logger;
        public IProductReceptionEventRepository _productReceptionEventRepository ;
        public GetProductReceptionEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductReceptionEventByIdQueryHandler> logger, IProductReceptionEventRepository productReceptionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productReceptionEventRepository = productReceptionEventRepository  ?? throw new ArgumentNullException(nameof(productReceptionEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductReceptionEventResponseDTO>> Handle(GetProductReceptionEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}