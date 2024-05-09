using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductPictureByIdQueryHandler  :  IRequestHandler<GetProductPictureByIdQuery, Either<GeneralFailure, ProductPictureResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductPictureByIdQueryHandler> _logger;
        public GetProductPictureByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductPictureByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductPictureResponseDTO>> Handle(GetProductPictureByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}