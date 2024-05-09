using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductLabellingEventByGuidQueryHandler  :  IRequestHandler<GetProductLabellingEventByGuidQuery, Either<GeneralFailure, ProductLabellingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductLabellingEventByGuidQueryHandler> _logger;
        public GetProductLabellingEventByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductLabellingEventByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductLabellingEventResponseDTO>> Handle(GetProductLabellingEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}