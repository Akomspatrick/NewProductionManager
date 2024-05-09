using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetMassfussionFunctionQueryHandler  :  IRequestHandler<GetMassfussionFunctionQuery, Either<GeneralFailure, MassfussionFunctionResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetMassfussionFunctionQueryHandler> _logger;
        public GetMassfussionFunctionQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetMassfussionFunctionQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, MassfussionFunctionResponseDTO>> Handle(GetMassfussionFunctionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}