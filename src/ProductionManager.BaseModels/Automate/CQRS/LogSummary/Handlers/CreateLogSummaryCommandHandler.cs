using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateLogSummaryCommandHandler  :  IRequestHandler<CreateLogSummaryCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateLogSummaryCommandHandler> _logger;
        public ILogSummaryRepository _logSummaryRepository ;
        public CreateLogSummaryCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateLogSummaryCommandHandler> logger, ILogSummaryRepository logSummaryRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logSummaryRepository = logSummaryRepository  ?? throw new ArgumentNullException(nameof(logSummaryRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateLogSummaryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.LogSummary.Create(request.logSummaryCreateDTO.LogSummaryName, request.logSummaryCreateDTO.Value.GuidId);return ( await  _logSummaryRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}