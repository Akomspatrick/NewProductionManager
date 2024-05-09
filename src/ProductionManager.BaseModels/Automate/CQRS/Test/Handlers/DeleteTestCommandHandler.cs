using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteTestCommandHandler  :  IRequestHandler<DeleteTestCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ITestRepository _testRepository ;
        private readonly ILogger<DeleteTestCommandHandler> _logger;
        public DeleteTestCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteTestCommandHandler> logger, ITestRepository testRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testRepository = testRepository  ?? throw new ArgumentNullException(nameof(testRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteTestCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _testRepository.DeleteByGuidAsync(request.DeleteTestDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.TestRepository.DeleteByGuidAsync(request.DeleteTestDTO.guid, cancellationToken);
        }
    }
}