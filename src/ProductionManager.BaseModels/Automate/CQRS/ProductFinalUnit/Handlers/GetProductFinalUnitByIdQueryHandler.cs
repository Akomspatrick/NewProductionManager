using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinalUnitByIdQueryHandler  :  IRequestHandler<GetProductFinalUnitByIdQuery, Either<GeneralFailure, ProductFinalUnitResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductFinalUnitByIdQueryHandler> _logger;
        public IProductFinalUnitRepository _productFinalUnitRepository ;
        public GetProductFinalUnitByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductFinalUnitByIdQueryHandler> logger, IProductFinalUnitRepository productFinalUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinalUnitRepository = productFinalUnitRepository  ?? throw new ArgumentNullException(nameof(productFinalUnitRepository ));
        }

        public async Task<Either<GeneralFailure, ProductFinalUnitResponseDTO>> Handle(GetProductFinalUnitByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}