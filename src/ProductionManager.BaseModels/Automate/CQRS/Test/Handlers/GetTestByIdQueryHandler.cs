using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTestByIdQueryHandler  :  IRequestHandler<GetTestByIdQuery, Either<GeneralFailure, TestResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTestByIdQueryHandler> _logger;
        public ITestRepository _testRepository ;
        public GetTestByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTestByIdQueryHandler> logger, ITestRepository testRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testRepository = testRepository  ?? throw new ArgumentNullException(nameof(testRepository ));
        }

        public async Task<Either<GeneralFailure, TestResponseDTO>> Handle(GetTestByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}