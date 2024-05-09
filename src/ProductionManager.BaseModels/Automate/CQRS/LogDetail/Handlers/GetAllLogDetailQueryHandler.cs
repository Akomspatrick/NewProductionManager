using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllLogDetailQueryHandler  :  IRequestHandler<GetAllLogDetailQuery, Either<GeneralFailure, IEnumerable<LogDetailResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllLogDetailQueryHandler> _logger;
        public ILogDetailRepository _logDetailRepository ;
        public GetAllLogDetailQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllLogDetailQueryHandler> logger, ILogDetailRepository logDetailRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logDetailRepository = logDetailRepository  ?? throw new ArgumentNullException(nameof(logDetailRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<LogDetailResponseDTO>>> Handle(GetAllLogDetailQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}