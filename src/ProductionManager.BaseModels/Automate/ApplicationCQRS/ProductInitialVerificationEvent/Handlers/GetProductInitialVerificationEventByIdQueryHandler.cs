using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInitialVerificationEventByIdQueryHandler  :  IRequestHandler<GetProductInitialVerificationEventByIdQuery, Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductInitialVerificationEventByIdQueryHandler> _logger;
        public GetProductInitialVerificationEventByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductInitialVerificationEventByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>> Handle(GetProductInitialVerificationEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}