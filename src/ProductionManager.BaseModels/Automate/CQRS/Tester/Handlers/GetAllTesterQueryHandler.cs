using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllTesterQueryHandler  :  IRequestHandler<GetAllTesterQuery, Either<GeneralFailure, IEnumerable<TesterResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllTesterQueryHandler> _logger;
        public ITesterRepository _testerRepository ;
        public GetAllTesterQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllTesterQueryHandler> logger, ITesterRepository testerRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testerRepository = testerRepository  ?? throw new ArgumentNullException(nameof(testerRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<TesterResponseDTO>>> Handle(GetAllTesterQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}