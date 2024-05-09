using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllAmplifierBoardQueryHandler  :  IRequestHandler<GetAllAmplifierBoardQuery, Either<GeneralFailure, IEnumerable<AmplifierBoardResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllAmplifierBoardQueryHandler> _logger;
        public GetAllAmplifierBoardQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllAmplifierBoardQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<AmplifierBoardResponseDTO>>> Handle(GetAllAmplifierBoardQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}