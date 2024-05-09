using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductReceptionEventQueryHandler  :  IRequestHandler<GetProductReceptionEventQuery, Either<GeneralFailure, ProductReceptionEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductReceptionEventQueryHandler> _logger;
        public GetProductReceptionEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductReceptionEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductReceptionEventResponseDTO>> Handle(GetProductReceptionEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}