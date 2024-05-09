using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductPictureQueryHandler  :  IRequestHandler<GetProductPictureQuery, Either<GeneralFailure, ProductPictureResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductPictureQueryHandler> _logger;
        public GetProductPictureQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductPictureQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductPictureResponseDTO>> Handle(GetProductPictureQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}