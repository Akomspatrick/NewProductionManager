using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTesterQueryHandler  :  IRequestHandler<GetTesterQuery, Either<GeneralFailure, TesterResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetTesterQueryHandler> _logger;
        public GetTesterQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetTesterQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, TesterResponseDTO>> Handle(GetTesterQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}