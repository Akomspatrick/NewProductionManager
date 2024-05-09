using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateTesterCommandHandler  :  IRequestHandler<CreateTesterCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateTesterCommandHandler> _logger;
        public ITesterRepository _testerRepository ;
        public CreateTesterCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateTesterCommandHandler> logger, ITesterRepository testerRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testerRepository = testerRepository  ?? throw new ArgumentNullException(nameof(testerRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateTesterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.Tester.Create(request.testerCreateDTO.TesterName, request.testerCreateDTO.Value.GuidId);return ( await  _testerRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}