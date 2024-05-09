using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductStageQueryHandler  :  IRequestHandler<GetAllProductStageQuery, Either<GeneralFailure, IEnumerable<ProductStageResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductStageQueryHandler> _logger;
        public GetAllProductStageQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductStageQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductStageResponseDTO>>> Handle(GetAllProductStageQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}