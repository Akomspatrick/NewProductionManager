using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductWiringEventQueryHandler  :  IRequestHandler<GetAllProductWiringEventQuery, Either<GeneralFailure, IEnumerable<ProductWiringEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductWiringEventQueryHandler> _logger;
        public IProductWiringEventRepository _productWiringEventRepository ;
        public GetAllProductWiringEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductWiringEventQueryHandler> logger, IProductWiringEventRepository productWiringEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productWiringEventRepository = productWiringEventRepository  ?? throw new ArgumentNullException(nameof(productWiringEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductWiringEventResponseDTO>>> Handle(GetAllProductWiringEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}