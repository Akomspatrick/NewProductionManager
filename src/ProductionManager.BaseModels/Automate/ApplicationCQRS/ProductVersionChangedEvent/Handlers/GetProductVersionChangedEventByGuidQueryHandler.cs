using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductVersionChangedEventByGuidQueryHandler  :  IRequestHandler<GetProductVersionChangedEventByGuidQuery, Either<GeneralFailure, ProductVersionChangedEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductVersionChangedEventByGuidQueryHandler> _logger;
        public GetProductVersionChangedEventByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductVersionChangedEventByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductVersionChangedEventResponseDTO>> Handle(GetProductVersionChangedEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}