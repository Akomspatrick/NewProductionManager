using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateTestCommandHandler  :  IRequestHandler<CreateTestCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateTestCommandHandler> _logger;
        public ITestRepository _testRepository ;
        public CreateTestCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateTestCommandHandler> logger, ITestRepository testRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testRepository = testRepository  ?? throw new ArgumentNullException(nameof(testRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateTestCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.Test.Create(request.testCreateDTO.TestName, request.testCreateDTO.Value.GuidId);return ( await  _testRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}