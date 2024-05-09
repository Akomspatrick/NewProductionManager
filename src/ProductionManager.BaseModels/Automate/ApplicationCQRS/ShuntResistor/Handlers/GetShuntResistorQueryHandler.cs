using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetShuntResistorQueryHandler  :  IRequestHandler<GetShuntResistorQuery, Either<GeneralFailure, ShuntResistorResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetShuntResistorQueryHandler> _logger;
        public GetShuntResistorQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetShuntResistorQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ShuntResistorResponseDTO>> Handle(GetShuntResistorQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}