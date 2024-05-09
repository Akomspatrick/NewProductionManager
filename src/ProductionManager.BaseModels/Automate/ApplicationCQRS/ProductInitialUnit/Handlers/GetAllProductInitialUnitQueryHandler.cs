using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductInitialUnitQueryHandler  :  IRequestHandler<GetAllProductInitialUnitQuery, Either<GeneralFailure, IEnumerable<ProductInitialUnitResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductInitialUnitQueryHandler> _logger;
        public GetAllProductInitialUnitQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductInitialUnitQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductInitialUnitResponseDTO>>> Handle(GetAllProductInitialUnitQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}