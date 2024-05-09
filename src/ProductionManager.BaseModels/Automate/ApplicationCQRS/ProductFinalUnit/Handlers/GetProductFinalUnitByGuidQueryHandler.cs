using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductFinalUnitByGuidQueryHandler  :  IRequestHandler<GetProductFinalUnitByGuidQuery, Either<GeneralFailure, ProductFinalUnitResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductFinalUnitByGuidQueryHandler> _logger;
        public GetProductFinalUnitByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductFinalUnitByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductFinalUnitResponseDTO>> Handle(GetProductFinalUnitByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}