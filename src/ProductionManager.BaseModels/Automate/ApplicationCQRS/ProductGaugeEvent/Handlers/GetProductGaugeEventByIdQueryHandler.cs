using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductGaugeEventByIdQueryHandler  :  IRequestHandler<GetProductGaugeEventByIdQuery, Either<GeneralFailure, ProductGaugeEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductGaugeEventByIdQueryHandler> _logger;
        public GetProductGaugeEventByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductGaugeEventByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductGaugeEventResponseDTO>> Handle(GetProductGaugeEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}