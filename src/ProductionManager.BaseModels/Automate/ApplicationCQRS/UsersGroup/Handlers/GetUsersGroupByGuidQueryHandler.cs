using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetUsersGroupByGuidQueryHandler  :  IRequestHandler<GetUsersGroupByGuidQuery, Either<GeneralFailure, UsersGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetUsersGroupByGuidQueryHandler> _logger;
        public GetUsersGroupByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetUsersGroupByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, UsersGroupResponseDTO>> Handle(GetUsersGroupByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}