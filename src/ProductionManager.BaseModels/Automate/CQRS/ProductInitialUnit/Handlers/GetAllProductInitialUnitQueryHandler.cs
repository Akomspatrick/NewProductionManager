using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductInitialUnitQueryHandler  :  IRequestHandler<GetAllProductInitialUnitQuery, Either<GeneralFailure, IEnumerable<ProductInitialUnitResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductInitialUnitQueryHandler> _logger;
        public IProductInitialUnitRepository _productInitialUnitRepository ;
        public GetAllProductInitialUnitQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductInitialUnitQueryHandler> logger, IProductInitialUnitRepository productInitialUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInitialUnitRepository = productInitialUnitRepository  ?? throw new ArgumentNullException(nameof(productInitialUnitRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductInitialUnitResponseDTO>>> Handle(GetAllProductInitialUnitQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}