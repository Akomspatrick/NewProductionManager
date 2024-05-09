using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductGaugeInspectionEventByGuidQueryHandler  :  IRequestHandler<GetProductGaugeInspectionEventByGuidQuery, Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductGaugeInspectionEventByGuidQueryHandler> _logger;
        public IProductGaugeInspectionEventRepository _productGaugeInspectionEventRepository ;
        public GetProductGaugeInspectionEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductGaugeInspectionEventByGuidQueryHandler> logger, IProductGaugeInspectionEventRepository productGaugeInspectionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeInspectionEventRepository = productGaugeInspectionEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeInspectionEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>> Handle(GetProductGaugeInspectionEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}