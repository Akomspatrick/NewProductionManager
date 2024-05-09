using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductQueryHandler  :  IRequestHandler<GetAllProductQuery, Either<GeneralFailure, IEnumerable<ProductResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductQueryHandler> _logger;
        public GetAllProductQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductResponseDTO>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}