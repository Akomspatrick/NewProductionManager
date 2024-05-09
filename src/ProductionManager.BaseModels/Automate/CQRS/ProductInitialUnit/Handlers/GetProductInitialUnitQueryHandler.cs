using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInitialUnitQueryHandler  :  IRequestHandler<GetProductInitialUnitQuery, Either<GeneralFailure, ProductInitialUnitResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductInitialUnitQueryHandler> _logger;
        public IProductInitialUnitRepository _productInitialUnitRepository ;
        public GetProductInitialUnitQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductInitialUnitQueryHandler> logger, IProductInitialUnitRepository productInitialUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInitialUnitRepository = productInitialUnitRepository  ?? throw new ArgumentNullException(nameof(productInitialUnitRepository ));
        }

        public async Task<Either<GeneralFailure, ProductInitialUnitResponseDTO>> Handle(GetProductInitialUnitQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}