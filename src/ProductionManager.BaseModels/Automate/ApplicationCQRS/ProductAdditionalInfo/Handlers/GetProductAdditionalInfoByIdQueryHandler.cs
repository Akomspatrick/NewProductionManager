using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductAdditionalInfoByIdQueryHandler  :  IRequestHandler<GetProductAdditionalInfoByIdQuery, Either<GeneralFailure, ProductAdditionalInfoResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductAdditionalInfoByIdQueryHandler> _logger;
        public GetProductAdditionalInfoByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductAdditionalInfoByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductAdditionalInfoResponseDTO>> Handle(GetProductAdditionalInfoByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}