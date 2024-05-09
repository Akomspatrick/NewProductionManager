using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateNonConformanceLogCommandHandler  :  IRequestHandler<CreateNonConformanceLogCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateNonConformanceLogCommandHandler> _logger;
        public INonConformanceLogRepository _nonConformanceLogRepository ;
        public CreateNonConformanceLogCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateNonConformanceLogCommandHandler> logger, INonConformanceLogRepository nonConformanceLogRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _nonConformanceLogRepository = nonConformanceLogRepository  ?? throw new ArgumentNullException(nameof(nonConformanceLogRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateNonConformanceLogCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.NonConformanceLog.Create(request.nonConformanceLogCreateDTO.NonConformanceLogName, request.nonConformanceLogCreateDTO.Value.GuidId);return ( await  _nonConformanceLogRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}