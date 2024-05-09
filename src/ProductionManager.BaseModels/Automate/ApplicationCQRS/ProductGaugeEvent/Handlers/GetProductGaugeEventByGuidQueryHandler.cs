using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductGaugeEventByGuidQueryHandler  :  IRequestHandler<GetProductGaugeEventByGuidQuery, Either<GeneralFailure, ProductGaugeEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductGaugeEventByGuidQueryHandler> _logger;
        public GetProductGaugeEventByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductGaugeEventByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductGaugeEventResponseDTO>> Handle(GetProductGaugeEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}