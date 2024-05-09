using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductVersionChangedEventQueryHandler  :  IRequestHandler<GetAllProductVersionChangedEventQuery, Either<GeneralFailure, IEnumerable<ProductVersionChangedEventResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProductVersionChangedEventQueryHandler> _logger;
        public IProductVersionChangedEventRepository _productVersionChangedEventRepository ;
        public GetAllProductVersionChangedEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProductVersionChangedEventQueryHandler> logger, IProductVersionChangedEventRepository productVersionChangedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productVersionChangedEventRepository = productVersionChangedEventRepository  ?? throw new ArgumentNullException(nameof(productVersionChangedEventRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductVersionChangedEventResponseDTO>>> Handle(GetAllProductVersionChangedEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}