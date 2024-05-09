using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinalUnitByGuidQueryHandler  :  IRequestHandler<GetProductFinalUnitByGuidQuery, Either<GeneralFailure, ProductFinalUnitResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductFinalUnitByGuidQueryHandler> _logger;
        public IProductFinalUnitRepository _productFinalUnitRepository ;
        public GetProductFinalUnitByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductFinalUnitByGuidQueryHandler> logger, IProductFinalUnitRepository productFinalUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalUnitRepository = productFinalUnitRepository  ?? throw new ArgumentNullException(nameof(productFinalUnitRepository ));
        }

        public async Task<Either<GeneralFailure, ProductFinalUnitResponseDTO>> Handle(GetProductFinalUnitByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}