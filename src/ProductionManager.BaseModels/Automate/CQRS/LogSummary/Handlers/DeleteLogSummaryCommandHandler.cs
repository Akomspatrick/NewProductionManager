using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteLogSummaryCommandHandler  :  IRequestHandler<DeleteLogSummaryCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ILogSummaryRepository _logSummaryRepository ;
        private readonly ILogger<DeleteLogSummaryCommandHandler> _logger;
        public DeleteLogSummaryCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteLogSummaryCommandHandler> logger, ILogSummaryRepository logSummaryRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logSummaryRepository = logSummaryRepository  ?? throw new ArgumentNullException(nameof(logSummaryRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteLogSummaryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _logSummaryRepository.DeleteByGuidAsync(request.DeleteLogSummaryDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.LogSummaryRepository.DeleteByGuidAsync(request.DeleteLogSummaryDTO.guid, cancellationToken);
        }
    }
}