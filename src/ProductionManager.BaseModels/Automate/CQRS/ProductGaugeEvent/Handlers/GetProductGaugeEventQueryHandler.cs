using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductGaugeEventQueryHandler  :  IRequestHandler<GetProductGaugeEventQuery, Either<GeneralFailure, ProductGaugeEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductGaugeEventQueryHandler> _logger;
        public IProductGaugeEventRepository _productGaugeEventRepository ;
        public GetProductGaugeEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductGaugeEventQueryHandler> logger, IProductGaugeEventRepository productGaugeEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeEventRepository = productGaugeEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductGaugeEventResponseDTO>> Handle(GetProductGaugeEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}