using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductVersionChangedEventByIdQueryHandler  :  IRequestHandler<GetProductVersionChangedEventByIdQuery, Either<GeneralFailure, ProductVersionChangedEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductVersionChangedEventByIdQueryHandler> _logger;
        public IProductVersionChangedEventRepository _productVersionChangedEventRepository ;
        public GetProductVersionChangedEventByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductVersionChangedEventByIdQueryHandler> logger, IProductVersionChangedEventRepository productVersionChangedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productVersionChangedEventRepository = productVersionChangedEventRepository  ?? throw new ArgumentNullException(nameof(productVersionChangedEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductVersionChangedEventResponseDTO>> Handle(GetProductVersionChangedEventByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}