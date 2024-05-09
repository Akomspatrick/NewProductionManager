using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductShippingEventByIdQueryHandler  :  IRequestHandler<GetProductShippingEventByIdQuery, Either<GeneralFailure, ProductShippingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductShippingEventByIdQueryHandler> _logger;
        public IProductShippingEventRepository _productShippingEventRepository ;
        public GetProductShippingEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductShippingEventByIdQueryHandler> logger, IProductShippingEventRepository productShippingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productShippingEventRepository = productShippingEventRepository  ?? throw new ArgumentNullException(nameof(productShippingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductShippingEventResponseDTO>> Handle(GetProductShippingEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}