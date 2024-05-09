using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductVersionChangedEventQueryHandler  :  IRequestHandler<GetAllProductVersionChangedEventQuery, Either<GeneralFailure, IEnumerable<ProductVersionChangedEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductVersionChangedEventQueryHandler> _logger;
        public GetAllProductVersionChangedEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductVersionChangedEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductVersionChangedEventResponseDTO>>> Handle(GetAllProductVersionChangedEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}