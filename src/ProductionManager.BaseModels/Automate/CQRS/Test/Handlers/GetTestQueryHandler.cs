using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTestQueryHandler  :  IRequestHandler<GetTestQuery, Either<GeneralFailure, TestResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTestQueryHandler> _logger;
        public ITestRepository _testRepository ;
        public GetTestQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTestQueryHandler> logger, ITestRepository testRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testRepository = testRepository  ?? throw new ArgumentNullException(nameof(testRepository ));
        }

        public async Task<Either<GeneralFailure, TestResponseDTO>> Handle(GetTestQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}