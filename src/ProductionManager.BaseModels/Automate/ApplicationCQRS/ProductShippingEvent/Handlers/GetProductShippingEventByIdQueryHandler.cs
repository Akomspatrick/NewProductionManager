using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductShippingEventByIdQueryHandler  :  IRequestHandler<GetProductShippingEventByIdQuery, Either<GeneralFailure, ProductShippingEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductShippingEventByIdQueryHandler> _logger;
        public GetProductShippingEventByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductShippingEventByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductShippingEventResponseDTO>> Handle(GetProductShippingEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}