using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllRefreshTokenQueryHandler  :  IRequestHandler<GetAllRefreshTokenQuery, Either<GeneralFailure, IEnumerable<RefreshTokenResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllRefreshTokenQueryHandler> _logger;
        public GetAllRefreshTokenQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllRefreshTokenQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<RefreshTokenResponseDTO>>> Handle(GetAllRefreshTokenQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}