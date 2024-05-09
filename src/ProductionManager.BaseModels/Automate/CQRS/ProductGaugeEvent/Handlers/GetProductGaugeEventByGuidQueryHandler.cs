using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductGaugeEventByGuidQueryHandler  :  IRequestHandler<GetProductGaugeEventByGuidQuery, Either<GeneralFailure, ProductGaugeEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductGaugeEventByGuidQueryHandler> _logger;
        public IProductGaugeEventRepository _productGaugeEventRepository ;
        public GetProductGaugeEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductGaugeEventByGuidQueryHandler> logger, IProductGaugeEventRepository productGaugeEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeEventRepository = productGaugeEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductGaugeEventResponseDTO>> Handle(GetProductGaugeEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}