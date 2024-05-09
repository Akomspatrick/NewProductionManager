using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateLogDetailCommandHandler  :  IRequestHandler<CreateLogDetailCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateLogDetailCommandHandler> _logger;
        public ILogDetailRepository _logDetailRepository ;
        public CreateLogDetailCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateLogDetailCommandHandler> logger, ILogDetailRepository logDetailRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _logDetailRepository = logDetailRepository  ?? throw new ArgumentNullException(nameof(logDetailRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateLogDetailCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.LogDetail.Create(request.logDetailCreateDTO.LogDetailName, request.logDetailCreateDTO.Value.GuidId);return ( await  _logDetailRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}