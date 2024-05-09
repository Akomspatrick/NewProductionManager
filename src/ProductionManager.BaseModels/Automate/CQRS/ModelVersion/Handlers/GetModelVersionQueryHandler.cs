using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetModelVersionQueryHandler  :  IRequestHandler<GetModelVersionQuery, Either<GeneralFailure, ModelVersionResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetModelVersionQueryHandler> _logger;
        public IModelVersionRepository _modelVersionRepository ;
        public GetModelVersionQueryHandler(IUnitOfWork unitOfWork, ILogger<GetModelVersionQueryHandler> logger, IModelVersionRepository modelVersionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelVersionRepository = modelVersionRepository  ?? throw new ArgumentNullException(nameof(modelVersionRepository ));
        }

        public async Task<Either<GeneralFailure, ModelVersionResponseDTO>> Handle(GetModelVersionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}