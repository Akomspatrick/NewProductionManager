using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTestByGuidQueryHandler  :  IRequestHandler<GetTestByGuidQuery, Either<GeneralFailure, TestResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTestByGuidQueryHandler> _logger;
        public ITestRepository _testRepository ;
        public GetTestByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTestByGuidQueryHandler> logger, ITestRepository testRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testRepository = testRepository  ?? throw new ArgumentNullException(nameof(testRepository ));
        }

        public async Task<Either<GeneralFailure, TestResponseDTO>> Handle(GetTestByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}