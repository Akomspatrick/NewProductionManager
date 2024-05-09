using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllModelVersionQueryHandler  :  IRequestHandler<GetAllModelVersionQuery, Either<GeneralFailure, IEnumerable<ModelVersionResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllModelVersionQueryHandler> _logger;
        public IModelVersionRepository _modelVersionRepository ;
        public GetAllModelVersionQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllModelVersionQueryHandler> logger, IModelVersionRepository modelVersionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelVersionRepository = modelVersionRepository  ?? throw new ArgumentNullException(nameof(modelVersionRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ModelVersionResponseDTO>>> Handle(GetAllModelVersionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}