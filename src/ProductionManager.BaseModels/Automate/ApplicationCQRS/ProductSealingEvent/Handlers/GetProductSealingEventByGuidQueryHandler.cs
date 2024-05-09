using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductSealingEventByGuidQueryHandler  :  IRequestHandler<GetProductSealingEventByGuidQuery, Either<GeneralFailure, ProductSealingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductSealingEventByGuidQueryHandler> _logger;
        public GetProductSealingEventByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductSealingEventByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductSealingEventResponseDTO>> Handle(GetProductSealingEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}