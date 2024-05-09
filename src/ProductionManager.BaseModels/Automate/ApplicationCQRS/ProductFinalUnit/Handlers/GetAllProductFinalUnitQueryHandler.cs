using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllProductFinalUnitQueryHandler  :  IRequestHandler<GetAllProductFinalUnitQuery, Either<GeneralFailure, IEnumerable<ProductFinalUnitResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllProductFinalUnitQueryHandler> _logger;
        public GetAllProductFinalUnitQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllProductFinalUnitQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProductFinalUnitResponseDTO>>> Handle(GetAllProductFinalUnitQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}