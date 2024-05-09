using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetMassfussionFunctionByGuidQueryHandler  :  IRequestHandler<GetMassfussionFunctionByGuidQuery, Either<GeneralFailure, MassfussionFunctionResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetMassfussionFunctionByGuidQueryHandler> _logger;
        public GetMassfussionFunctionByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetMassfussionFunctionByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, MassfussionFunctionResponseDTO>> Handle(GetMassfussionFunctionByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}