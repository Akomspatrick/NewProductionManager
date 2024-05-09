using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetMassfussionFunctionByIdQueryHandler  :  IRequestHandler<GetMassfussionFunctionByIdQuery, Either<GeneralFailure, MassfussionFunctionResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetMassfussionFunctionByIdQueryHandler> _logger;
        public GetMassfussionFunctionByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetMassfussionFunctionByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, MassfussionFunctionResponseDTO>> Handle(GetMassfussionFunctionByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}