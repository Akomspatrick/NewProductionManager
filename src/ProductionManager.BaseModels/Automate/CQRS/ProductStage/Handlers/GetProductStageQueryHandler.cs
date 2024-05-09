using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductStageQueryHandler  :  IRequestHandler<GetProductStageQuery, Either<GeneralFailure, ProductStageResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductStageQueryHandler> _logger;
        public IProductStageRepository _productStageRepository ;
        public GetProductStageQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductStageQueryHandler> logger, IProductStageRepository productStageRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productStageRepository = productStageRepository  ?? throw new ArgumentNullException(nameof(productStageRepository ));
        }

        public async Task<Either<GeneralFailure, ProductStageResponseDTO>> Handle(GetProductStageQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}