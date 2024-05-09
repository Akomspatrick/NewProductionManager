using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductVersionChangedEventByGuidQueryHandler  :  IRequestHandler<GetProductVersionChangedEventByGuidQuery, Either<GeneralFailure, ProductVersionChangedEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductVersionChangedEventByGuidQueryHandler> _logger;
        public IProductVersionChangedEventRepository _productVersionChangedEventRepository ;
        public GetProductVersionChangedEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductVersionChangedEventByGuidQueryHandler> logger, IProductVersionChangedEventRepository productVersionChangedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productVersionChangedEventRepository = productVersionChangedEventRepository  ?? throw new ArgumentNullException(nameof(productVersionChangedEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductVersionChangedEventResponseDTO>> Handle(GetProductVersionChangedEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}