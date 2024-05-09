using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetUsersGroupQueryHandler  :  IRequestHandler<GetUsersGroupQuery, Either<GeneralFailure, UsersGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetUsersGroupQueryHandler> _logger;
        public GetUsersGroupQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetUsersGroupQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, UsersGroupResponseDTO>> Handle(GetUsersGroupQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}