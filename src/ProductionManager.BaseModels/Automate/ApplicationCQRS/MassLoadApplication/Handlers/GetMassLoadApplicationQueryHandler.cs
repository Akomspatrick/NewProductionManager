using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetMassLoadApplicationQueryHandler  :  IRequestHandler<GetMassLoadApplicationQuery, Either<GeneralFailure, MassLoadApplicationResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetMassLoadApplicationQueryHandler> _logger;
        public GetMassLoadApplicationQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetMassLoadApplicationQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, MassLoadApplicationResponseDTO>> Handle(GetMassLoadApplicationQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}