using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinishedEventByGuidQueryHandler  :  IRequestHandler<GetProductFinishedEventByGuidQuery, Either<GeneralFailure, ProductFinishedEventResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProductFinishedEventByGuidQueryHandler> _logger;
        public IProductFinishedEventRepository _productFinishedEventRepository ;
        public GetProductFinishedEventByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProductFinishedEventByGuidQueryHandler> logger, IProductFinishedEventRepository productFinishedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productFinishedEventRepository = productFinishedEventRepository  ?? throw new ArgumentNullException(nameof(productFinishedEventRepository ));
        }

        public async Task<Either<GeneralFailure, ProductFinishedEventResponseDTO>> Handle(GetProductFinishedEventByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}