using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductLabellingEventByIdQueryHandler  :  IRequestHandler<GetProductLabellingEventByIdQuery, Either<GeneralFailure, ProductLabellingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductLabellingEventByIdQueryHandler> _logger;
        public IProductLabellingEventRepository _productLabellingEventRepository ;
        public GetProductLabellingEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductLabellingEventByIdQueryHandler> logger, IProductLabellingEventRepository productLabellingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productLabellingEventRepository = productLabellingEventRepository  ?? throw new ArgumentNullException(nameof(productLabellingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductLabellingEventResponseDTO>> Handle(GetProductLabellingEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}