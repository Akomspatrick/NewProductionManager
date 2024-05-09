using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductShippingEventQueryHandler  :  IRequestHandler<GetProductShippingEventQuery, Either<GeneralFailure, ProductShippingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductShippingEventQueryHandler> _logger;
        public IProductShippingEventRepository _productShippingEventRepository ;
        public GetProductShippingEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductShippingEventQueryHandler> logger, IProductShippingEventRepository productShippingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productShippingEventRepository = productShippingEventRepository  ?? throw new ArgumentNullException(nameof(productShippingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductShippingEventResponseDTO>> Handle(GetProductShippingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}