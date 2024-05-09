using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductGaugeInspectionEventByIdQueryHandler  :  IRequestHandler<GetProductGaugeInspectionEventByIdQuery, Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductGaugeInspectionEventByIdQueryHandler> _logger;
        public GetProductGaugeInspectionEventByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductGaugeInspectionEventByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>> Handle(GetProductGaugeInspectionEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}