using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductLabellingEventQueryHandler  :  IRequestHandler<GetAllProductLabellingEventQuery, Either<GeneralFailure, IEnumerable<ProductLabellingEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductLabellingEventQueryHandler> _logger;
        public IProductLabellingEventRepository _productLabellingEventRepository ;
        public GetAllProductLabellingEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductLabellingEventQueryHandler> logger, IProductLabellingEventRepository productLabellingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productLabellingEventRepository = productLabellingEventRepository  ?? throw new ArgumentNullException(nameof(productLabellingEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductLabellingEventResponseDTO>>> Handle(GetAllProductLabellingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}