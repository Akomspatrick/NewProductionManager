using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInitialUnitByIdQueryHandler  :  IRequestHandler<GetProductInitialUnitByIdQuery, Either<GeneralFailure, ProductInitialUnitResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductInitialUnitByIdQueryHandler> _logger;
        public IProductInitialUnitRepository _productInitialUnitRepository ;
        public GetProductInitialUnitByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductInitialUnitByIdQueryHandler> logger, IProductInitialUnitRepository productInitialUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInitialUnitRepository = productInitialUnitRepository  ?? throw new ArgumentNullException(nameof(productInitialUnitRepository ));
        }

        public async Task<Either<GeneralFailure, ProductInitialUnitResponseDTO>> Handle(GetProductInitialUnitByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}