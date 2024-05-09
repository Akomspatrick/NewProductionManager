using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetLogDetailByGuidQueryHandler  :  IRequestHandler<GetLogDetailByGuidQuery, Either<GeneralFailure, LogDetailResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetLogDetailByGuidQueryHandler> _logger;
        public ILogDetailRepository _logDetailRepository ;
        public GetLogDetailByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetLogDetailByGuidQueryHandler> logger, ILogDetailRepository logDetailRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logDetailRepository = logDetailRepository  ?? throw new ArgumentNullException(nameof(logDetailRepository ));
        }

        public async Task<Either<GeneralFailure, LogDetailResponseDTO>> Handle(GetLogDetailByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}