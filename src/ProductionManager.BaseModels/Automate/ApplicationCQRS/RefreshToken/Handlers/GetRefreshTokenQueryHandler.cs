using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetRefreshTokenQueryHandler  :  IRequestHandler<GetRefreshTokenQuery, Either<GeneralFailure, RefreshTokenResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetRefreshTokenQueryHandler> _logger;
        public GetRefreshTokenQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetRefreshTokenQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, RefreshTokenResponseDTO>> Handle(GetRefreshTokenQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}