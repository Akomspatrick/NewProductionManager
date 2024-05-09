using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductShippingEventQueryHandler  :  IRequestHandler<GetAllProductShippingEventQuery, Either<GeneralFailure, IEnumerable<ProductShippingEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductShippingEventQueryHandler> _logger;
        public GetAllProductShippingEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductShippingEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductShippingEventResponseDTO>>> Handle(GetAllProductShippingEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}