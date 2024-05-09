using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductWiringEventQueryHandler  :  IRequestHandler<GetProductWiringEventQuery, Either<GeneralFailure, ProductWiringEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductWiringEventQueryHandler> _logger;
        public IProductWiringEventRepository _productWiringEventRepository ;
        public GetProductWiringEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductWiringEventQueryHandler> logger, IProductWiringEventRepository productWiringEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productWiringEventRepository = productWiringEventRepository  ?? throw new ArgumentNullException(nameof(productWiringEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductWiringEventResponseDTO>> Handle(GetProductWiringEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}