using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAmplifierBoardByGuidQueryHandler  :  IRequestHandler<GetAmplifierBoardByGuidQuery, Either<GeneralFailure, AmplifierBoardResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAmplifierBoardByGuidQueryHandler> _logger;
        public GetAmplifierBoardByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAmplifierBoardByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, AmplifierBoardResponseDTO>> Handle(GetAmplifierBoardByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}