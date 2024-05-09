using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductFinishedEventQueryHandler  :  IRequestHandler<GetAllProductFinishedEventQuery, Either<GeneralFailure, IEnumerable<ProductFinishedEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductFinishedEventQueryHandler> _logger;
        public GetAllProductFinishedEventQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductFinishedEventQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductFinishedEventResponseDTO>>> Handle(GetAllProductFinishedEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}