using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCablingEventByGuidQueryHandler  :  IRequestHandler<GetProductCablingEventByGuidQuery, Either<GeneralFailure, ProductCablingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductCablingEventByGuidQueryHandler> _logger;
        public IProductCablingEventRepository _productCablingEventRepository ;
        public GetProductCablingEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductCablingEventByGuidQueryHandler> logger, IProductCablingEventRepository productCablingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCablingEventRepository = productCablingEventRepository  ?? throw new ArgumentNullException(nameof(productCablingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductCablingEventResponseDTO>> Handle(GetProductCablingEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}