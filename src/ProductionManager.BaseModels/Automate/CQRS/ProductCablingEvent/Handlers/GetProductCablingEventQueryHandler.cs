using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCablingEventQueryHandler  :  IRequestHandler<GetProductCablingEventQuery, Either<GeneralFailure, ProductCablingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductCablingEventQueryHandler> _logger;
        public IProductCablingEventRepository _productCablingEventRepository ;
        public GetProductCablingEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductCablingEventQueryHandler> logger, IProductCablingEventRepository productCablingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCablingEventRepository = productCablingEventRepository  ?? throw new ArgumentNullException(nameof(productCablingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductCablingEventResponseDTO>> Handle(GetProductCablingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}