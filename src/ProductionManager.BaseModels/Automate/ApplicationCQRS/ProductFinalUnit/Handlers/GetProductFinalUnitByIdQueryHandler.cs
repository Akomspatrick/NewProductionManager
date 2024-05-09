using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinalUnitByIdQueryHandler  :  IRequestHandler<GetProductFinalUnitByIdQuery, Either<GeneralFailure, ProductFinalUnitResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductFinalUnitByIdQueryHandler> _logger;
        public GetProductFinalUnitByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductFinalUnitByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductFinalUnitResponseDTO>> Handle(GetProductFinalUnitByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}