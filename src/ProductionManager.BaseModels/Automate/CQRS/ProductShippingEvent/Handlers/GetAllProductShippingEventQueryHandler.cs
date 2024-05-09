using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductShippingEventQueryHandler  :  IRequestHandler<GetAllProductShippingEventQuery, Either<GeneralFailure, IEnumerable<ProductShippingEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductShippingEventQueryHandler> _logger;
        public IProductShippingEventRepository _productShippingEventRepository ;
        public GetAllProductShippingEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductShippingEventQueryHandler> logger, IProductShippingEventRepository productShippingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productShippingEventRepository = productShippingEventRepository  ?? throw new ArgumentNullException(nameof(productShippingEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductShippingEventResponseDTO>>> Handle(GetAllProductShippingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}