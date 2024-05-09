using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductGaugeInspectionEventByGuidQueryHandler  :  IRequestHandler<GetProductGaugeInspectionEventByGuidQuery, Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductGaugeInspectionEventByGuidQueryHandler> _logger;
        public GetProductGaugeInspectionEventByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductGaugeInspectionEventByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>> Handle(GetProductGaugeInspectionEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}