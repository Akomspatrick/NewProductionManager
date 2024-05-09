using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetModelVersionByIdQueryHandler  :  IRequestHandler<GetModelVersionByIdQuery, Either<GeneralFailure, ModelVersionResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetModelVersionByIdQueryHandler> _logger;
        public IModelVersionRepository _modelVersionRepository ;
        public GetModelVersionByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetModelVersionByIdQueryHandler> logger, IModelVersionRepository modelVersionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelVersionRepository = modelVersionRepository  ?? throw new ArgumentNullException(nameof(modelVersionRepository ));
        }

        public async Task<Either<GeneralFailure, ModelVersionResponseDTO>> Handle(GetModelVersionByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}