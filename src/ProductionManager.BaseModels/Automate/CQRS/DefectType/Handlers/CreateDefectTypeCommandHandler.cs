using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateDefectTypeCommandHandler  :  IRequestHandler<CreateDefectTypeCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateDefectTypeCommandHandler> _logger;
        public IDefectTypeRepository _defectTypeRepository ;
        public CreateDefectTypeCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateDefectTypeCommandHandler> logger, IDefectTypeRepository defectTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeRepository = defectTypeRepository  ?? throw new ArgumentNullException(nameof(defectTypeRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateDefectTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.DefectType.Create(request.defectTypeCreateDTO.DefectTypeName, request.defectTypeCreateDTO.Value.GuidId);return ( await  _defectTypeRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}