using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductGaugeInspectionEventQueryHandler  :  IRequestHandler<GetAllProductGaugeInspectionEventQuery, Either<GeneralFailure, IEnumerable<ProductGaugeInspectionEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductGaugeInspectionEventQueryHandler> _logger;
        public IProductGaugeInspectionEventRepository _productGaugeInspectionEventRepository ;
        public GetAllProductGaugeInspectionEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductGaugeInspectionEventQueryHandler> logger, IProductGaugeInspectionEventRepository productGaugeInspectionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeInspectionEventRepository = productGaugeInspectionEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeInspectionEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductGaugeInspectionEventResponseDTO>>> Handle(GetAllProductGaugeInspectionEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}