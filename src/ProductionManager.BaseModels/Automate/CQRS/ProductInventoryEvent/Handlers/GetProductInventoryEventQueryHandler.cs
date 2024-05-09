using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInventoryEventQueryHandler  :  IRequestHandler<GetProductInventoryEventQuery, Either<GeneralFailure, ProductInventoryEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductInventoryEventQueryHandler> _logger;
        public IProductInventoryEventRepository _productInventoryEventRepository ;
        public GetProductInventoryEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductInventoryEventQueryHandler> logger, IProductInventoryEventRepository productInventoryEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInventoryEventRepository = productInventoryEventRepository  ?? throw new ArgumentNullException(nameof(productInventoryEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductInventoryEventResponseDTO>> Handle(GetProductInventoryEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}