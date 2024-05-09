using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductFinalUnitQueryHandler  :  IRequestHandler<GetAllProductFinalUnitQuery, Either<GeneralFailure, IEnumerable<ProductFinalUnitResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductFinalUnitQueryHandler> _logger;
        public IProductFinalUnitRepository _productFinalUnitRepository ;
        public GetAllProductFinalUnitQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductFinalUnitQueryHandler> logger, IProductFinalUnitRepository productFinalUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalUnitRepository = productFinalUnitRepository  ?? throw new ArgumentNullException(nameof(productFinalUnitRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductFinalUnitResponseDTO>>> Handle(GetAllProductFinalUnitQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}