using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinishedEventQueryHandler  :  IRequestHandler<GetProductFinishedEventQuery, Either<GeneralFailure, ProductFinishedEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductFinishedEventQueryHandler> _logger;
        public IProductFinishedEventRepository _productFinishedEventRepository ;
        public GetProductFinishedEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductFinishedEventQueryHandler> logger, IProductFinishedEventRepository productFinishedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinishedEventRepository = productFinishedEventRepository  ?? throw new ArgumentNullException(nameof(productFinishedEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductFinishedEventResponseDTO>> Handle(GetProductFinishedEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}