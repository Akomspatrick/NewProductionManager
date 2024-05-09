using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductGaugeInspectionEventByIdQueryHandler  :  IRequestHandler<GetProductGaugeInspectionEventByIdQuery, Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductGaugeInspectionEventByIdQueryHandler> _logger;
        public IProductGaugeInspectionEventRepository _productGaugeInspectionEventRepository ;
        public GetProductGaugeInspectionEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductGaugeInspectionEventByIdQueryHandler> logger, IProductGaugeInspectionEventRepository productGaugeInspectionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeInspectionEventRepository = productGaugeInspectionEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeInspectionEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>> Handle(GetProductGaugeInspectionEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}