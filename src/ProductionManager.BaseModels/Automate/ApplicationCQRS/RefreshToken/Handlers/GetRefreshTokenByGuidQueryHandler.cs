using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetRefreshTokenByGuidQueryHandler  :  IRequestHandler<GetRefreshTokenByGuidQuery, Either<GeneralFailure, RefreshTokenResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetRefreshTokenByGuidQueryHandler> _logger;
        public GetRefreshTokenByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetRefreshTokenByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, RefreshTokenResponseDTO>> Handle(GetRefreshTokenByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}