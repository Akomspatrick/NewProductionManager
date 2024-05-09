using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInventoryEventByGuidQueryHandler  :  IRequestHandler<GetProductInventoryEventByGuidQuery, Either<GeneralFailure, ProductInventoryEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductInventoryEventByGuidQueryHandler> _logger;
        public IProductInventoryEventRepository _productInventoryEventRepository ;
        public GetProductInventoryEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductInventoryEventByGuidQueryHandler> logger, IProductInventoryEventRepository productInventoryEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInventoryEventRepository = productInventoryEventRepository  ?? throw new ArgumentNullException(nameof(productInventoryEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductInventoryEventResponseDTO>> Handle(GetProductInventoryEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}