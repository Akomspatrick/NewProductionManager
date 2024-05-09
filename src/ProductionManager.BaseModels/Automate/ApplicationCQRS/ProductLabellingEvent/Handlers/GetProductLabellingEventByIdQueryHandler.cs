using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductLabellingEventByIdQueryHandler  :  IRequestHandler<GetProductLabellingEventByIdQuery, Either<GeneralFailure, ProductLabellingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductLabellingEventByIdQueryHandler> _logger;
        public GetProductLabellingEventByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductLabellingEventByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductLabellingEventResponseDTO>> Handle(GetProductLabellingEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}