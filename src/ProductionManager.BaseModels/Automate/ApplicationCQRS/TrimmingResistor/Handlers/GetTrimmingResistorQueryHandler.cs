using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTrimmingResistorQueryHandler  :  IRequestHandler<GetTrimmingResistorQuery, Either<GeneralFailure, TrimmingResistorResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetTrimmingResistorQueryHandler> _logger;
        public GetTrimmingResistorQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetTrimmingResistorQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, TrimmingResistorResponseDTO>> Handle(GetTrimmingResistorQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}