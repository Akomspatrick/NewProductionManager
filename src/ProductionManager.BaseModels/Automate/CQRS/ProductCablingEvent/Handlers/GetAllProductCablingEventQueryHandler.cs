using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductCablingEventQueryHandler  :  IRequestHandler<GetAllProductCablingEventQuery, Either<GeneralFailure, IEnumerable<ProductCablingEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductCablingEventQueryHandler> _logger;
        public IProductCablingEventRepository _productCablingEventRepository ;
        public GetAllProductCablingEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductCablingEventQueryHandler> logger, IProductCablingEventRepository productCablingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCablingEventRepository = productCablingEventRepository  ?? throw new ArgumentNullException(nameof(productCablingEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductCablingEventResponseDTO>>> Handle(GetAllProductCablingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}