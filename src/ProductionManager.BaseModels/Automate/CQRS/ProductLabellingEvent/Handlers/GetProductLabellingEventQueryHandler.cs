using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductLabellingEventQueryHandler  :  IRequestHandler<GetProductLabellingEventQuery, Either<GeneralFailure, ProductLabellingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductLabellingEventQueryHandler> _logger;
        public IProductLabellingEventRepository _productLabellingEventRepository ;
        public GetProductLabellingEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductLabellingEventQueryHandler> logger, IProductLabellingEventRepository productLabellingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productLabellingEventRepository = productLabellingEventRepository  ?? throw new ArgumentNullException(nameof(productLabellingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductLabellingEventResponseDTO>> Handle(GetProductLabellingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}