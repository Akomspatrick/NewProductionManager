using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductWiringEventByGuidQueryHandler  :  IRequestHandler<GetProductWiringEventByGuidQuery, Either<GeneralFailure, ProductWiringEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductWiringEventByGuidQueryHandler> _logger;
        public IProductWiringEventRepository _productWiringEventRepository ;
        public GetProductWiringEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductWiringEventByGuidQueryHandler> logger, IProductWiringEventRepository productWiringEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productWiringEventRepository = productWiringEventRepository  ?? throw new ArgumentNullException(nameof(productWiringEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductWiringEventResponseDTO>> Handle(GetProductWiringEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}