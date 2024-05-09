using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductGaugeEventQueryHandler  :  IRequestHandler<GetAllProductGaugeEventQuery, Either<GeneralFailure, IEnumerable<ProductGaugeEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductGaugeEventQueryHandler> _logger;
        public IProductGaugeEventRepository _productGaugeEventRepository ;
        public GetAllProductGaugeEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductGaugeEventQueryHandler> logger, IProductGaugeEventRepository productGaugeEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeEventRepository = productGaugeEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductGaugeEventResponseDTO>>> Handle(GetAllProductGaugeEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}