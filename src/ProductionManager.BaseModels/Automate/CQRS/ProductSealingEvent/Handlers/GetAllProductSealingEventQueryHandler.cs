using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductSealingEventQueryHandler  :  IRequestHandler<GetAllProductSealingEventQuery, Either<GeneralFailure, IEnumerable<ProductSealingEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductSealingEventQueryHandler> _logger;
        public IProductSealingEventRepository _productSealingEventRepository ;
        public GetAllProductSealingEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductSealingEventQueryHandler> logger, IProductSealingEventRepository productSealingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSealingEventRepository = productSealingEventRepository  ?? throw new ArgumentNullException(nameof(productSealingEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductSealingEventResponseDTO>>> Handle(GetAllProductSealingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}