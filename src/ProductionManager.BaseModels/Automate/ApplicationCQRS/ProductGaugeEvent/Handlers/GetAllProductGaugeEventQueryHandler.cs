using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductGaugeEventQueryHandler  :  IRequestHandler<GetAllProductGaugeEventQuery, Either<GeneralFailure, IEnumerable<ProductGaugeEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductGaugeEventQueryHandler> _logger;
        public GetAllProductGaugeEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductGaugeEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductGaugeEventResponseDTO>>> Handle(GetAllProductGaugeEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}