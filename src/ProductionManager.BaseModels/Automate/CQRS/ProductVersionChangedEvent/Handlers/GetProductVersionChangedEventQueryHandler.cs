using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductVersionChangedEventQueryHandler  :  IRequestHandler<GetProductVersionChangedEventQuery, Either<GeneralFailure, ProductVersionChangedEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductVersionChangedEventQueryHandler> _logger;
        public IProductVersionChangedEventRepository _productVersionChangedEventRepository ;
        public GetProductVersionChangedEventQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductVersionChangedEventQueryHandler> logger, IProductVersionChangedEventRepository productVersionChangedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productVersionChangedEventRepository = productVersionChangedEventRepository  ?? throw new ArgumentNullException(nameof(productVersionChangedEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductVersionChangedEventResponseDTO>> Handle(GetProductVersionChangedEventQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}