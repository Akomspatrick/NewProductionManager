using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductStageByGuidQueryHandler  :  IRequestHandler<GetProductStageByGuidQuery, Either<GeneralFailure, ProductStageResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductStageByGuidQueryHandler> _logger;
        public IProductStageRepository _productStageRepository ;
        public GetProductStageByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductStageByGuidQueryHandler> logger, IProductStageRepository productStageRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productStageRepository = productStageRepository  ?? throw new ArgumentNullException(nameof(productStageRepository ));
        }

        public async Task<Either<GeneralFailure, ProductStageResponseDTO>> Handle(GetProductStageByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}