using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetUsersGroupByIdQueryHandler  :  IRequestHandler<GetUsersGroupByIdQuery, Either<GeneralFailure, UsersGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetUsersGroupByIdQueryHandler> _logger;
        public GetUsersGroupByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetUsersGroupByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, UsersGroupResponseDTO>> Handle(GetUsersGroupByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}