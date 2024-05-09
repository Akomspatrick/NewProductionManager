using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllTestQueryHandler  :  IRequestHandler<GetAllTestQuery, Either<GeneralFailure, IEnumerable<TestResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllTestQueryHandler> _logger;
        public ITestRepository _testRepository ;
        public GetAllTestQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllTestQueryHandler> logger, ITestRepository testRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testRepository = testRepository  ?? throw new ArgumentNullException(nameof(testRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<TestResponseDTO>>> Handle(GetAllTestQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}