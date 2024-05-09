using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateTestCommandHandler  :  IRequestHandler<UpdateTestCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateTestCommandHandler> _logger;
        public ITestRepository _testRepository ;
        private readonly IMapper _mapper;
        public UpdateTestCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateTestCommandHandler> logger, IMapper mapper, ITestRepository testRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _testRepository = testRepository  ?? throw new ArgumentNullException(nameof(testRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateTestCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.Test>(request.UpdateTestDTO);
            return await _testRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}