using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductStageQueryHandler  :  IRequestHandler<GetProductStageQuery, Either<GeneralFailure, ProductStageResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductStageQueryHandler> _logger;
        public GetProductStageQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductStageQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductStageResponseDTO>> Handle(GetProductStageQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}