using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTestQueryHandler  :  IRequestHandler<GetTestQuery, Either<GeneralFailure, TestResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetTestQueryHandler> _logger;
        public GetTestQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetTestQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, TestResponseDTO>> Handle(GetTestQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}