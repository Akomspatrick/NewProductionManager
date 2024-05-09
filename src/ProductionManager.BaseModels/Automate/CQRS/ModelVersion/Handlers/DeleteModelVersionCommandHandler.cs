using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteModelVersionCommandHandler  :  IRequestHandler<DeleteModelVersionCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IModelVersionRepository _modelVersionRepository ;
        private readonly ILogger<DeleteModelVersionCommandHandler> _logger;
        public DeleteModelVersionCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteModelVersionCommandHandler> logger, IModelVersionRepository modelVersionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelVersionRepository = modelVersionRepository  ?? throw new ArgumentNullException(nameof(modelVersionRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteModelVersionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _modelVersionRepository.DeleteByGuidAsync(request.DeleteModelVersionDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ModelVersionRepository.DeleteByGuidAsync(request.DeleteModelVersionDTO.guid, cancellationToken);
        }
    }
}