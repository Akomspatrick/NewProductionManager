using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCablingEventByIdQueryHandler  :  IRequestHandler<GetProductCablingEventByIdQuery, Either<GeneralFailure, ProductCablingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductCablingEventByIdQueryHandler> _logger;
        public IProductCablingEventRepository _productCablingEventRepository ;
        public GetProductCablingEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductCablingEventByIdQueryHandler> logger, IProductCablingEventRepository productCablingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productCablingEventRepository = productCablingEventRepository  ?? throw new ArgumentNullException(nameof(productCablingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductCablingEventResponseDTO>> Handle(GetProductCablingEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}