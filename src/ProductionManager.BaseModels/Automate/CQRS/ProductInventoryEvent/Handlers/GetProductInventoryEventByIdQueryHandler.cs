using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInventoryEventByIdQueryHandler  :  IRequestHandler<GetProductInventoryEventByIdQuery, Either<GeneralFailure, ProductInventoryEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductInventoryEventByIdQueryHandler> _logger;
        public IProductInventoryEventRepository _productInventoryEventRepository ;
        public GetProductInventoryEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductInventoryEventByIdQueryHandler> logger, IProductInventoryEventRepository productInventoryEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInventoryEventRepository = productInventoryEventRepository  ?? throw new ArgumentNullException(nameof(productInventoryEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductInventoryEventResponseDTO>> Handle(GetProductInventoryEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}