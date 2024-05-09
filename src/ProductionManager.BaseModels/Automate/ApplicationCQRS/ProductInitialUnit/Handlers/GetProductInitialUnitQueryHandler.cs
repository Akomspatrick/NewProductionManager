using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInitialUnitQueryHandler  :  IRequestHandler<GetProductInitialUnitQuery, Either<GeneralFailure, ProductInitialUnitResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductInitialUnitQueryHandler> _logger;
        public GetProductInitialUnitQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductInitialUnitQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductInitialUnitResponseDTO>> Handle(GetProductInitialUnitQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}