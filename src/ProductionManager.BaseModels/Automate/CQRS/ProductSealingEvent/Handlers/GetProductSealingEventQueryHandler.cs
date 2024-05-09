using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductSealingEventQueryHandler  :  IRequestHandler<GetProductSealingEventQuery, Either<GeneralFailure, ProductSealingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductSealingEventQueryHandler> _logger;
        public IProductSealingEventRepository _productSealingEventRepository ;
        public GetProductSealingEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductSealingEventQueryHandler> logger, IProductSealingEventRepository productSealingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSealingEventRepository = productSealingEventRepository  ?? throw new ArgumentNullException(nameof(productSealingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductSealingEventResponseDTO>> Handle(GetProductSealingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}