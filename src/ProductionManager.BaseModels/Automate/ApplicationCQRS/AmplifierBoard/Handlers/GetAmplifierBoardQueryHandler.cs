using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAmplifierBoardQueryHandler  :  IRequestHandler<GetAmplifierBoardQuery, Either<GeneralFailure, AmplifierBoardResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAmplifierBoardQueryHandler> _logger;
        public GetAmplifierBoardQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAmplifierBoardQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, AmplifierBoardResponseDTO>> Handle(GetAmplifierBoardQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}