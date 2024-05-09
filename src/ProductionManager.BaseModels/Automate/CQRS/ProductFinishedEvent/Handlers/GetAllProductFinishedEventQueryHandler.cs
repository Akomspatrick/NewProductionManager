using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductFinishedEventQueryHandler  :  IRequestHandler<GetAllProductFinishedEventQuery, Either<GeneralFailure, IEnumerable<ProductFinishedEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductFinishedEventQueryHandler> _logger;
        public IProductFinishedEventRepository _productFinishedEventRepository ;
        public GetAllProductFinishedEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductFinishedEventQueryHandler> logger, IProductFinishedEventRepository productFinishedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinishedEventRepository = productFinishedEventRepository  ?? throw new ArgumentNullException(nameof(productFinishedEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductFinishedEventResponseDTO>>> Handle(GetAllProductFinishedEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}