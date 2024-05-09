using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductLabellingEventQueryHandler  :  IRequestHandler<GetAllProductLabellingEventQuery, Either<GeneralFailure, IEnumerable<ProductLabellingEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductLabellingEventQueryHandler> _logger;
        public GetAllProductLabellingEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductLabellingEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductLabellingEventResponseDTO>>> Handle(GetAllProductLabellingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}