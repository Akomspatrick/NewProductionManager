using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinalUnitQueryHandler  :  IRequestHandler<GetProductFinalUnitQuery, Either<GeneralFailure, ProductFinalUnitResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductFinalUnitQueryHandler> _logger;
        public IProductFinalUnitRepository _productFinalUnitRepository ;
        public GetProductFinalUnitQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductFinalUnitQueryHandler> logger, IProductFinalUnitRepository productFinalUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalUnitRepository = productFinalUnitRepository  ?? throw new ArgumentNullException(nameof(productFinalUnitRepository ));
        }

        public async Task<Either<GeneralFailure, ProductFinalUnitResponseDTO>> Handle(GetProductFinalUnitQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}