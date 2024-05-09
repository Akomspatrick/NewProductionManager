using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAmplifierBoardByGuidQueryHandler  :  IRequestHandler<GetAmplifierBoardByGuidQuery, Either<GeneralFailure, AmplifierBoardResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAmplifierBoardByGuidQueryHandler> _logger;
        public IAmplifierBoardRepository _amplifierBoardRepository ;
        public GetAmplifierBoardByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAmplifierBoardByGuidQueryHandler> logger, IAmplifierBoardRepository amplifierBoardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _amplifierBoardRepository = amplifierBoardRepository  ?? throw new ArgumentNullException(nameof(amplifierBoardRepository ));
        }

        public async Task<Either<GeneralFailure, AmplifierBoardResponseDTO>> Handle(GetAmplifierBoardByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}