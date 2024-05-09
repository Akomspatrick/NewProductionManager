using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductSealingEventByIdQueryHandler  :  IRequestHandler<GetProductSealingEventByIdQuery, Either<GeneralFailure, ProductSealingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductSealingEventByIdQueryHandler> _logger;
        public IProductSealingEventRepository _productSealingEventRepository ;
        public GetProductSealingEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductSealingEventByIdQueryHandler> logger, IProductSealingEventRepository productSealingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productSealingEventRepository = productSealingEventRepository  ?? throw new ArgumentNullException(nameof(productSealingEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductSealingEventResponseDTO>> Handle(GetProductSealingEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}