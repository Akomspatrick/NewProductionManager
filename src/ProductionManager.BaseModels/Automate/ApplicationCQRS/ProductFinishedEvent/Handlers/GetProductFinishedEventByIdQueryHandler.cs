using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinishedEventByIdQueryHandler  :  IRequestHandler<GetProductFinishedEventByIdQuery, Either<GeneralFailure, ProductFinishedEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductFinishedEventByIdQueryHandler> _logger;
        public GetProductFinishedEventByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductFinishedEventByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductFinishedEventResponseDTO>> Handle(GetProductFinishedEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}