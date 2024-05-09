using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteLogDetailCommandHandler  :  IRequestHandler<DeleteLogDetailCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ILogDetailRepository _logDetailRepository ;
        private readonly ILogger<DeleteLogDetailCommandHandler> _logger;
        public DeleteLogDetailCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteLogDetailCommandHandler> logger, ILogDetailRepository logDetailRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logDetailRepository = logDetailRepository  ?? throw new ArgumentNullException(nameof(logDetailRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteLogDetailCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _logDetailRepository.DeleteByGuidAsync(request.DeleteLogDetailDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.LogDetailRepository.DeleteByGuidAsync(request.DeleteLogDetailDTO.guid, cancellationToken);
        }
    }
}