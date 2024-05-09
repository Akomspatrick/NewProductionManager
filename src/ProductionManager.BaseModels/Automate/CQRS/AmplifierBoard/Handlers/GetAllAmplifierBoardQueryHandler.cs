using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllAmplifierBoardQueryHandler  :  IRequestHandler<GetAllAmplifierBoardQuery, Either<GeneralFailure, IEnumerable<AmplifierBoardResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllAmplifierBoardQueryHandler> _logger;
        public IAmplifierBoardRepository _amplifierBoardRepository ;
        public GetAllAmplifierBoardQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllAmplifierBoardQueryHandler> logger, IAmplifierBoardRepository amplifierBoardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _amplifierBoardRepository = amplifierBoardRepository  ?? throw new ArgumentNullException(nameof(amplifierBoardRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<AmplifierBoardResponseDTO>>> Handle(GetAllAmplifierBoardQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}