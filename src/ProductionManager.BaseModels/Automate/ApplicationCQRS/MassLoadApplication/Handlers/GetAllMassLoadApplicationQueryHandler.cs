using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllMassLoadApplicationQueryHandler  :  IRequestHandler<GetAllMassLoadApplicationQuery, Either<GeneralFailure, IEnumerable<MassLoadApplicationResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllMassLoadApplicationQueryHandler> _logger;
        public GetAllMassLoadApplicationQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllMassLoadApplicationQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<MassLoadApplicationResponseDTO>>> Handle(GetAllMassLoadApplicationQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}