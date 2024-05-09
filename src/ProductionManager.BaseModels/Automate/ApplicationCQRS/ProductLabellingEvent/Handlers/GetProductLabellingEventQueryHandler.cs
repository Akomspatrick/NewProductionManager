using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductLabellingEventQueryHandler  :  IRequestHandler<GetProductLabellingEventQuery, Either<GeneralFailure, ProductLabellingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductLabellingEventQueryHandler> _logger;
        public GetProductLabellingEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductLabellingEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductLabellingEventResponseDTO>> Handle(GetProductLabellingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}