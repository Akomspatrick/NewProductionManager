using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductWiringEventByIdQueryHandler  :  IRequestHandler<GetProductWiringEventByIdQuery, Either<GeneralFailure, ProductWiringEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductWiringEventByIdQueryHandler> _logger;
        public IProductWiringEventRepository _productWiringEventRepository ;
        public GetProductWiringEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductWiringEventByIdQueryHandler> logger, IProductWiringEventRepository productWiringEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productWiringEventRepository = productWiringEventRepository  ?? throw new ArgumentNullException(nameof(productWiringEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductWiringEventResponseDTO>> Handle(GetProductWiringEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}