using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductSealingEventByGuidQueryHandler  :  IRequestHandler<GetProductSealingEventByGuidQuery, Either<GeneralFailure, ProductSealingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductSealingEventByGuidQueryHandler> _logger;
        public IProductSealingEventRepository _productSealingEventRepository ;
        public GetProductSealingEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductSealingEventByGuidQueryHandler> logger, IProductSealingEventRepository productSealingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSealingEventRepository = productSealingEventRepository  ?? throw new ArgumentNullException(nameof(productSealingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductSealingEventResponseDTO>> Handle(GetProductSealingEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}