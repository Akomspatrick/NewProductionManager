using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductInitialUnitByIdQueryHandler  :  IRequestHandler<GetProductInitialUnitByIdQuery, Either<GeneralFailure, ProductInitialUnitResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductInitialUnitByIdQueryHandler> _logger;
        public GetProductInitialUnitByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductInitialUnitByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductInitialUnitResponseDTO>> Handle(GetProductInitialUnitByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}