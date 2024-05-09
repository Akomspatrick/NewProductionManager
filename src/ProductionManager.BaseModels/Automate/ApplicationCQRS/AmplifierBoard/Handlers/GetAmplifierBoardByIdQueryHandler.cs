using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAmplifierBoardByIdQueryHandler  :  IRequestHandler<GetAmplifierBoardByIdQuery, Either<GeneralFailure, AmplifierBoardResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAmplifierBoardByIdQueryHandler> _logger;
        public GetAmplifierBoardByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAmplifierBoardByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, AmplifierBoardResponseDTO>> Handle(GetAmplifierBoardByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}