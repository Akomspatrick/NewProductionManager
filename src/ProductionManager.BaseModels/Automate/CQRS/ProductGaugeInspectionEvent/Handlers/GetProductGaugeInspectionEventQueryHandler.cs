using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductGaugeInspectionEventQueryHandler  :  IRequestHandler<GetProductGaugeInspectionEventQuery, Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductGaugeInspectionEventQueryHandler> _logger;
        public IProductGaugeInspectionEventRepository _productGaugeInspectionEventRepository ;
        public GetProductGaugeInspectionEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductGaugeInspectionEventQueryHandler> logger, IProductGaugeInspectionEventRepository productGaugeInspectionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeInspectionEventRepository = productGaugeInspectionEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeInspectionEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>> Handle(GetProductGaugeInspectionEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}