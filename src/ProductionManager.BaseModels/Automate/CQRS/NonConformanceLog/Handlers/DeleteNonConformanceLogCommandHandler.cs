using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteNonConformanceLogCommandHandler  :  IRequestHandler<DeleteNonConformanceLogCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public INonConformanceLogRepository _nonConformanceLogRepository ;
        private readonly ILogger<DeleteNonConformanceLogCommandHandler> _logger;
        public DeleteNonConformanceLogCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteNonConformanceLogCommandHandler> logger, INonConformanceLogRepository nonConformanceLogRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _nonConformanceLogRepository = nonConformanceLogRepository  ?? throw new ArgumentNullException(nameof(nonConformanceLogRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteNonConformanceLogCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _nonConformanceLogRepository.DeleteByGuidAsync(request.DeleteNonConformanceLogDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.NonConformanceLogRepository.DeleteByGuidAsync(request.DeleteNonConformanceLogDTO.guid, cancellationToken);
        }
    }
}