using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTesterByIdQueryHandler  :  IRequestHandler<GetTesterByIdQuery, Either<GeneralFailure, TesterResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTesterByIdQueryHandler> _logger;
        public ITesterRepository _testerRepository ;
        public GetTesterByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTesterByIdQueryHandler> logger, ITesterRepository testerRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testerRepository = testerRepository  ?? throw new ArgumentNullException(nameof(testerRepository ));
        }

        public async Task<Either<GeneralFailure, TesterResponseDTO>> Handle(GetTesterByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}