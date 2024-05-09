using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductInventoryEventQueryHandler  :  IRequestHandler<GetAllProductInventoryEventQuery, Either<GeneralFailure, IEnumerable<ProductInventoryEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductInventoryEventQueryHandler> _logger;
        public IProductInventoryEventRepository _productInventoryEventRepository ;
        public GetAllProductInventoryEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductInventoryEventQueryHandler> logger, IProductInventoryEventRepository productInventoryEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInventoryEventRepository = productInventoryEventRepository  ?? throw new ArgumentNullException(nameof(productInventoryEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductInventoryEventResponseDTO>>> Handle(GetAllProductInventoryEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}