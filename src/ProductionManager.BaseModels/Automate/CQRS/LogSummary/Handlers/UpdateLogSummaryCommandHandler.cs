using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateLogSummaryCommandHandler  :  IRequestHandler<UpdateLogSummaryCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateLogSummaryCommandHandler> _logger;
        public ILogSummaryRepository _logSummaryRepository ;
        private readonly IMapper _mapper;
        public UpdateLogSummaryCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateLogSummaryCommandHandler> logger, IMapper mapper, ILogSummaryRepository logSummaryRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logSummaryRepository = logSummaryRepository  ?? throw new ArgumentNullException(nameof(logSummaryRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateLogSummaryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.LogSummary>(request.UpdateLogSummaryDTO);
            return await _logSummaryRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}