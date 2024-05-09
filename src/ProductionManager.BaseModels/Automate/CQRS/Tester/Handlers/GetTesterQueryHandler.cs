using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTesterQueryHandler  :  IRequestHandler<GetTesterQuery, Either<GeneralFailure, TesterResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTesterQueryHandler> _logger;
        public ITesterRepository _testerRepository ;
        public GetTesterQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTesterQueryHandler> logger, ITesterRepository testerRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testerRepository = testerRepository  ?? throw new ArgumentNullException(nameof(testerRepository ));
        }

        public async Task<Either<GeneralFailure, TesterResponseDTO>> Handle(GetTesterQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}