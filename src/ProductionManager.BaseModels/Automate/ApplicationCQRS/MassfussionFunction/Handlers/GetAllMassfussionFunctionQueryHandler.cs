using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllMassfussionFunctionQueryHandler  :  IRequestHandler<GetAllMassfussionFunctionQuery, Either<GeneralFailure, IEnumerable<MassfussionFunctionResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllMassfussionFunctionQueryHandler> _logger;
        public GetAllMassfussionFunctionQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllMassfussionFunctionQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<MassfussionFunctionResponseDTO>>> Handle(GetAllMassfussionFunctionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}